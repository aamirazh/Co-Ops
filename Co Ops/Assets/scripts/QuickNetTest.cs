
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class QuickNetTest : MonoBehaviour
{

    NetworkClient client;

    void InitializeClient()
    {
        client = new NetworkClient();
        client.RegisterHandler(MsgType.Connect, OnClientConnect);

        client.Connect(inputHost, 7777);
    }

    void InitializeServer()
    {
        NetworkServer.Listen(7777);

        NetworkServer.RegisterHandler(MsgType.Connect, OnServerConnect);
    }

    void OnServerConnect(NetworkMessage netMsg)
    {
        Debug.Log(string.Format("Client has connected to server with connection id: {0}", netMsg.conn.connectionId));

        NetworkServer.SetClientReady(netMsg.conn);
    }

    void OnClientConnect(NetworkMessage netMsg)
    {
        Debug.Log(string.Format("Client has connected to server"));
    }

    string inputHost = "localhost";

    void OnGUI()
    {
        if (!NetworkServer.active)
        {
            if (GUI.Button(new Rect(400, 20, 200, 20), "Init Server"))
            {
                InitializeServer();
            }
        }

        if (client == null || !client.isConnected)
        {
            if (GUI.Button(new Rect(100, 20, 200, 20), "Client Connect"))
            {
                InitializeClient();
            }

            inputHost = GUI.TextField(new Rect(100, 60, 200, 20), inputHost);
        }
    }
}