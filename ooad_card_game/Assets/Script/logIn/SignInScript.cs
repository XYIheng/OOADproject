using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Net;
using System.Net.Sockets;

public class SignInScript : MonoBehaviour {

    public TextMeshProUGUI username;
    public TextMeshProUGUI password;

    public void sendToServer() {


        string message = "username: " + username.text + ";" + "password: " + password.text + ";";
        print(message);


        Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        string host = "127.0.0.1";
        int port = 6666;
        clientSocket.Connect(host, port);
        byte[] bytes = System.Text.Encoding.Default.GetBytes(message);
        clientSocket.Send(bytes);
        clientSocket.Close();

    }
}
