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
        Debug.Log("Server Start");

    }

    void OnDestroy()
    {
        server.Stop();
        server = null;
    }

}

public class Echo : WebSocketBehavior
{
    protected override void OnMessage( MessageEventArgs e )
    {
        Sessions.Broadcast( e.Data );
        Debug.Log("Server Receive Msg:" + e.Data);
    }
}