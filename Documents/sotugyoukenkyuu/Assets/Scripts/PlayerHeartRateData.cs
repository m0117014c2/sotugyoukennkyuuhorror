﻿using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Text;
using System;
using System.Linq;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class PlayerHeartRateData
{
    private static PlayerHeartRateData data = default;
    private List<HeartRate> dataList = new List<HeartRate>();

    private HeartRate title = default;

    private Action overListener = default;

    private PlayerHeartRateData()
    {
    }
    public static PlayerHeartRateData GetInstance()
    {
        if ( data == null)
        {
            data = new PlayerHeartRateData();
        }
        return data;
    }

    /// <summary>
    /// タイトル画面の心拍数を記録する
    /// </summary>
    public void RecordHeartRateAtTitle()
    {
        title = dataList.LastOrDefault();
        if(title != null)
        {
            Debug.Log($"タイトル画面の心拍数:{title.heartRate}");
        }
    }
    public void AddListener(Action callback)
    {
        overListener = callback;
    }
    public void RemoveListener()
    {
        overListener = null;
    }
    public void  Add(HeartRate heartRate)
    {
        dataList.Add(heartRate);
        if (title != null && heartRate.heartRate > title.heartRate*1.1f )
        {
            overListener?.Invoke();
        }
    }
    private string GetCSV()
    {
        var sb = new StringBuilder("State,HeartRate,HeartRateAvg,HeartRateMax");
        foreach (var rate in dataList)
        {
            sb.Append("\r\n").Append(rate.heartRateState)
                .Append(',').Append(rate.heartRate.ToString())
                .Append(',').Append(rate.heartRateAvg.ToString())
                .Append(',').Append(rate.heartRateMax.ToString());
        }

        return sb.ToString();
    }
    public void SaveToFile()
    {
        // Use the CSV generation from before
        var content = GetCSV();

        // The target file path e.g.
#if UNITY_EDITOR
        var folder = Application.streamingAssetsPath;

        if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
#else
    var folder = Application.persistentDataPath;
#endif

        var filePath = Path.Combine(folder, "export_"+DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")+ ".csv");

        using (var writer = new StreamWriter(filePath, false))
        {
            writer.Write(content);
        }

        // Or just
        //File.WriteAllText(content);

        Debug.Log($"CSV file written to <{filePath}>");

#if UNITY_EDITOR
        AssetDatabase.Refresh();
#endif
    }
}
