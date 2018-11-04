using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;


public class clientsocket : MonoBehaviour
{

    Socket clientSocket;

    byte[] readbuff = new byte[1024];

    public void connectServer()
    {
        clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        string host = "127.0.0.1";
        int port = 6666;

        clientSocket.Connect(host, port);


        string str = "message1";

        byte[] bytes = System.Text.Encoding.Default.GetBytes(str);

        clientSocket.Send(bytes);

        clientSocket.Close();


    }

    private void Start()
    {
        connectServer();
    }
}
