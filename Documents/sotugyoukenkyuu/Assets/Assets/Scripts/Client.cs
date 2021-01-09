using UnityEngine;
using WebSocketSharp;
using WebSocketSharp.Net;

public class Client : MonoBehaviour
{

    WebSocket ws;

    void Start()
    {
        ws = new WebSocket( "ws://localhost:7681","mionix-beta" );

        ws.OnOpen += ( sender, e ) =>
        {
            Debug.Log( "WebSocket Open" );
        };

        ws.OnMessage += ( sender, e ) =>
        {
            Debug.Log( "WebSocket Message Data: " + e.Data );
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

    void Update()
    {

        if ( Input.GetKeyUp( "s" ) )
        {
            ws.Send( "s click" );
        }
        if ( Input.GetKeyUp( "c" ) )
        {
            ws.Send( "c click" );
        }
    }
    public void Connect()
    {
        ws.Connect();
    }
    void OnDestroy()
    {
        ws.Close();
        ws = null;
    }
}
