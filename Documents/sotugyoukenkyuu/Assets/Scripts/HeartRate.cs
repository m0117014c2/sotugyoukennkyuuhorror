using System;
public class HeartRate
{
    //{ "type":"bioMetrics","heartRateState":"active","heartRate":62.3,"heartRateAvg":62.3,"heartRateMax":62.3,"gsr":0.5157750691233135}
    public string type;
    public string heartRateState;
    public float heartRate;
    public float heartRateAvg;
    public float heartRateMax;
    public float gsr;
    public string time = string.Empty;
    public HeartRate()
    {
    }
}
