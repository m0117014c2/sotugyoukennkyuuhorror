using System;
using UnityEngine;
using WebSocketSharp;

public class Receiver : MonoBehaviour
{

    WebSocket ws;
    private bool isSend = false;

    private float delta = 3.0f; 
    private float interval = 1.0f;
    PlayerHeartRateData datas = default;

    void Start()
    {
        datas = PlayerHeartRateData.GetInstance();

        ws = new WebSocket( "ws://localhost:3000/" );

        ws.OnOpen += ( sender, e ) =>
        {
            Debug.Log( "WebSocket Open" );
        };

        ws.OnMessage += ( sender, e ) =>
        {
            //Debug.Log( "WebSocket Message Data: " + e.Data );
            Parse(e.Data);
        };

        ws.OnError += ( sender, e ) =>
        {
            Debug.Log( "WebSocket Error Message: " + e.Message );
        };

        ws.OnClose += ( sender, e ) =>
        {
            Debug.Log( "WebSocket Close" );
        };
    }
    public void AddListener(Action callback)
    {
        datas.AddListener(callback);
    }
    public void RemoveListener()
    {
        datas.RemoveListener();
    }
    private void Parse(string data)
    {
        if (data.Contains("bioMetrics"))
        {
            HeartRate heartRate = JsonUtility.FromJson<HeartRate>(data);
            datas.Add(heartRate);
            //Debug.Log($"heart rate state = {heartRate.heartRateState}");
            Debug.Log($"heart rate = {heartRate.heartRate}");
            //Debug.Log($"heart rate avg = {heartRate.heartRateAvg}");
            //Debug.Log($"heart rate max = {heartRate.heartRateMax}");
        }
        else
        {
            //Debug.Log($"心拍データではありません!");
        }
    }

    private void Update()
    {
        if (!isSend)
        {
            return;
        }

        delta -= Time.deltaTime;
        if ( delta <= 0)
        {
            Send();
            delta = interval;
        }
    }

    public void Connect()
    {
        ws.Connect();
    }

    public void SaveToFile()
    {
        datas.SaveToFile();
    }
    /// <summary>
    /// サーバーのテストデータ初期化
    /// </summary>
    public void StartSend()
    {
        ws.Send("InitData");
        isSend = true;
    }

    private void Send()
    {
        ws.Send("Send");
    }

    /// <summary>
    /// タイマー停止
    /// </summary>
    public void StopSend()
    {
        isSend = false;
    }

    void OnDestroy()
    {
        ws.Close();
        ws = null;
    }
}
