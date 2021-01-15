using System.Collections.Generic;

public class TestData
{
    Queue<string> queue = new Queue<string>();
    public TestData()
    {
    }

    public string GetTestData()
    {
        if (queue.Count > 0)
        {
            return queue.Dequeue();
        }
        return string.Empty;
    }

    /// <summary>
    /// ダミーデータ初期化
    /// </summary>
    public void InitTestData()
    {
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":111860800,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"mouseMetrics\",\"totalTime\":48568504.0,\"totalDistance\":541664.8125,\"totalScrolls\":32235,\"totalClicks\":19458,\"streakTime\":12501.0,\"streakDistance\":387.6937255859375,\"streakScrolls\":0,\"streakClicks\":5,\"speed\":0.0,\"speedAvg\":0.02881237305700779,\"speedMax\":0.04359374940395355,\"clickRate\":0.5,\"clickRateAvg\":0.27596867084503176,\"clickRateMax\":0.5,\"scrollRate\":0.0,\"scrollRateAvg\":0.0,\"scrollRateMax\":0.0}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":108119360,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioMetrics\",\"heartRateState\":\"active\",\"heartRate\":62.3,\"heartRateAvg\":62.3,\"heartRateMax\":62.3,\"gsr\":0.9243065885746762}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":105316416,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"mouseMetrics\",\"totalTime\":48568760.0,\"totalDistance\":541672.125,\"totalScrolls\":32235,\"totalClicks\":19458,\"streakTime\":12754.0,\"streakDistance\":395.07562255859377,\"streakScrolls\":0,\"streakClicks\":5,\"speed\":0.12742789089679719,\"speedAvg\":0.029079994186758996,\"speedMax\":0.12742789089679719,\"clickRate\":0.5,\"clickRateAvg\":0.27596867084503176,\"clickRateMax\":0.5,\"scrollRate\":0.0,\"scrollRateAvg\":0.0,\"scrollRateMax\":0.0}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":107695232,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":107695232,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioMetrics\",\"heartRateState\":\"active\",\"heartRate\":62.3,\"heartRateAvg\":62.3,\"heartRateMax\":62.3,\"gsr\":0.9867702119987681}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":116170560,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"mouseMetrics\",\"totalTime\":48568864.0,\"totalDistance\":541691.5,\"totalScrolls\":32235,\"totalClicks\":19458,\"streakTime\":12862.0,\"streakDistance\":414.3731384277344,\"streakScrolls\":0,\"streakClicks\":5,\"speed\":0.14754807949066163,\"speedAvg\":0.02980700135231018,\"speedMax\":0.1953645795583725,\"clickRate\":0.5,\"clickRateAvg\":0.27596867084503176,\"clickRateMax\":0.5,\"scrollRate\":0.0,\"scrollRateAvg\":0.0,\"scrollRateMax\":0.0}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":121775744,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":124475456,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioMetrics\",\"heartRateState\":\"active\",\"heartRate\":62.3,\"heartRateAvg\":62.3,\"heartRateMax\":62.3,\"gsr\":0.97092520836174}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":126254016,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"mouseMetrics\",\"totalTime\":48568972.0,\"totalDistance\":541706.25,\"totalScrolls\":32235,\"totalClicks\":19458,\"streakTime\":12969.0,\"streakDistance\":429.13690185546877,\"streakScrolls\":0,\"streakClicks\":5,\"speed\":0.11625000089406967,\"speedAvg\":0.030470170080661775,\"speedMax\":0.20585937798023225,\"clickRate\":1.4836795330047608,\"clickRateAvg\":0.3860577940940857,\"clickRateMax\":1.4836795330047608,\"scrollRate\":0.0,\"scrollRateAvg\":0.0,\"scrollRateMax\":0.0}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":126619328,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioMetrics\",\"heartRateState\":\"active\",\"heartRate\":62.3,\"heartRateAvg\":62.3,\"heartRateMax\":62.3,\"gsr\":0.7798799496303477}");
        queue.Enqueue("{ \"type\":\"mouseMetrics\",\"totalTime\":48569080.0,\"totalDistance\":541715.4375,\"totalScrolls\":32235,\"totalClicks\":19458,\"streakTime\":13077.0,\"streakDistance\":438.3787536621094,\"streakScrolls\":0,\"streakClicks\":5,\"speed\":0.05085937678813934,\"speedAvg\":0.030580833554267885,\"speedMax\":0.20585937798023225,\"clickRate\":1.4836795330047608,\"clickRateAvg\":0.3860577940940857,\"clickRateMax\":1.4836795330047608,\"scrollRate\":0.0,\"scrollRateAvg\":0.0,\"scrollRateMax\":0.0}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":126053376,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":126053376,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":122687296,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioMetrics\",\"heartRateState\":\"active\",\"heartRate\":62.3,\"heartRateAvg\":62.3,\"heartRateMax\":62.3,\"gsr\":0.5157750691233135}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":111814720,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"mouseMetrics\",\"totalTime\":48569148.0,\"totalDistance\":541717.75,\"totalScrolls\":32235,\"totalClicks\":19458,\"streakTime\":13145.0,\"streakDistance\":440.7037353515625,\"streakScrolls\":0,\"streakClicks\":5,\"speed\":0.0,\"speedAvg\":0.03002491593360901,\"speedMax\":0.20585937798023225,\"clickRate\":1.4836795330047608,\"clickRateAvg\":0.3860577940940857,\"clickRateMax\":1.4836795330047608,\"scrollRate\":0.0,\"scrollRateAvg\":0.0,\"scrollRateMax\":0.0}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":107091776,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":109818496,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioMetrics\",\"heartRateState\":\"active\",\"heartRate\":62.3,\"heartRateAvg\":62.3,\"heartRateMax\":62.3,\"gsr\":0.6227826424008429}");
        queue.Enqueue("{ \"type\":\"mouseMetrics\",\"totalTime\":48569148.0,\"totalDistance\":541717.75,\"totalScrolls\":32235,\"totalClicks\":19458,\"streakTime\":13145.0,\"streakDistance\":440.7037353515625,\"streakScrolls\":0,\"streakClicks\":5,\"speed\":0.0,\"speedAvg\":0.029335858300328256,\"speedMax\":0.20585937798023225,\"clickRate\":1.4836795330047608,\"clickRateAvg\":0.3860577940940857,\"clickRateMax\":1.4836795330047608,\"scrollRate\":0.0,\"scrollRateAvg\":0.0,\"scrollRateMax\":0.0}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":110752576,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":110752576,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":107896512,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioMetrics\",\"heartRateState\":\"active\",\"heartRate\":92.3,\"heartRateAvg\":62.3,\"heartRateMax\":62.3,\"gsr\":0.897584750725165}");
        queue.Enqueue("{ \"type\":\"mouseMetrics\",\"totalTime\":48569400.0,\"totalDistance\":541721.125,\"totalScrolls\":32235,\"totalClicks\":19458,\"streakTime\":13398.0,\"streakDistance\":444.07501220703127,\"streakScrolls\":0,\"streakClicks\":5,\"speed\":0.0871874988079071,\"speedAvg\":0.029013097286224366,\"speedMax\":0.20585937798023225,\"clickRate\":1.4836795330047608,\"clickRateAvg\":0.3860577940940857,\"clickRateMax\":1.4836795330047608,\"scrollRate\":0.0,\"scrollRateAvg\":0.0,\"scrollRateMax\":0.0}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":105229568,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":106257664,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":109951360,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioMetrics\",\"heartRateState\":\"active\",\"heartRate\":62.3,\"heartRateAvg\":62.3,\"heartRateMax\":62.3,\"gsr\":0.9810975338188017}");
        queue.Enqueue("{ \"type\":\"mouseMetrics\",\"totalTime\":48569512.0,\"totalDistance\":541728.125,\"totalScrolls\":32235,\"totalClicks\":19458,\"streakTime\":13506.0,\"streakDistance\":451.04998779296877,\"streakScrolls\":0,\"streakClicks\":5,\"speed\":0.03632812574505806,\"speedAvg\":0.029417235404253007,\"speedMax\":0.20585937798023225,\"clickRate\":1.4836795330047608,\"clickRateAvg\":0.3860577940940857,\"clickRateMax\":1.4836795330047608,\"scrollRate\":0.0,\"scrollRateAvg\":0.0,\"scrollRateMax\":0.0}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":110619136,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"mouseMetrics\",\"totalTime\":48569616.0,\"totalDistance\":541730.5,\"totalScrolls\":32235,\"totalClicks\":19458,\"streakTime\":13612.0,\"streakDistance\":453.404052734375,\"streakScrolls\":0,\"streakClicks\":5,\"speed\":0.01614583469927311,\"speedAvg\":0.029453061521053315,\"speedMax\":0.20585937798023225,\"clickRate\":1.4836795330047608,\"clickRateAvg\":0.3860577940940857,\"clickRateMax\":1.4836795330047608,\"scrollRate\":0.0,\"scrollRateAvg\":0.0,\"scrollRateMax\":0.0}");
        queue.Enqueue("{ \"type\":\"bioMetrics\",\"heartRateState\":\"active\",\"heartRate\":62.3,\"heartRateAvg\":62.3,\"heartRateMax\":62.3,\"gsr\":0.8548188844414388}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":112118592,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":112118592,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":113498624,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":115059584,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"mouseMetrics\",\"totalTime\":48569724.0,\"totalDistance\":541731.75,\"totalScrolls\":32235,\"totalClicks\":19458,\"streakTime\":13719.0,\"streakDistance\":454.68280029296877,\"streakScrolls\":0,\"streakClicks\":5,\"speed\":0.013413460925221444,\"speedAvg\":0.0294580589979887,\"speedMax\":0.20585937798023225,\"clickRate\":1.4836795330047608,\"clickRateAvg\":0.3860577940940857,\"clickRateMax\":1.4836795330047608,\"scrollRate\":0.0,\"scrollRateAvg\":0.0,\"scrollRateMax\":0.0}");
        queue.Enqueue("{ \"type\":\"bioMetrics\",\"heartRateState\":\"active\",\"heartRate\":62.3,\"heartRateAvg\":62.3,\"heartRateMax\":62.3,\"gsr\":0.5693907162060585}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":115527232,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":115096128,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"bioRaw\",\"hr\":115598528,\"dt\":40,\"touch\":true}");
        queue.Enqueue("{ \"type\":\"mouseMetrics\",\"totalTime\":48569824.0,\"totalDistance\":541732.25,\"totalScrolls\":32235,\"totalClicks\":19458,\"streakTime\":13819.0,\"streakDistance\":455.1768798828125,\"streakScrolls\":0,\"streakClicks\":5,\"speed\":0.004471153952181339,\"speedAvg\":0.02953113615512848,\"speedMax\":0.20585937798023225,\"clickRate\":1.4836795330047608,\"clickRateAvg\":0.3860577940940857,\"clickRateMax\":1.4836795330047608,\"scrollRate\":0.0,\"scrollRateAvg\":0.0,\"scrollRateMax\":0.0}");
        queue.Enqueue("{ \"type\":\"bioMetrics\",\"heartRateState\":\"active\",\"heartRate\":62.3,\"heartRateAvg\":62.3,\"heartRateMax\":62.3,\"gsr\":0.4565594321314882}");
    }
}
