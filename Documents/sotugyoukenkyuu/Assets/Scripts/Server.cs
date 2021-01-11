using UnityEngine;
using WebSocketSharp;
using WebSocketSharp.Server;

public class Server : MonoBehaviour
{
    WebSocketServer server;

    void Start()
    {
        server = new WebSocketServer( 3000 );

        server.AddWebSocketService<Echo>( "/" );
        server.Start();
    }

    void OnDestroy()
    {
        server.Stop();
        server = null;
    }

}

public class Echo : WebSocketBehavior
{
    /// <summary>
    /// テストデータ
    /// </summary>
    private TestData testData = default;

    protected override void OnMessage( MessageEventArgs msg )
    {
        if (msg.Data == "InitData")
        {
            Debug.Log("InitData");
            if ( testData == null)
            {
                testData = new TestData();
                testData.InitTestData();
            }
        }
        else if (msg.Data == "Send")
        {
            var data = testData.GetTestData();
            if (data == string.Empty)
            {
                Debug.Log("No Data");
            }
            else
            {
                Sessions.Broadcast(data);
            }
        }
    }
}