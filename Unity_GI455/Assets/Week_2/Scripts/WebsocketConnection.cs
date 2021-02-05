using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using UnityEngine.UI;


namespace ProgramChar
{

    
        
    public class WebsocketConnection : MonoBehaviour
    {
        public List<Message> messageList = new List<Message>();

        private WebSocket websocket;

        public GameObject inputField;
        public GameObject inputField1;
        public GameObject ChatInPut;
        public GameObject ChatMessage;
        public GameObject Chatwindow, textObject;
        public GameObject NameInput;

        public string _IP;
        public string _Port;
        public string _Chat;
        public string _nameText;
        
        /*public GameObject chatcontainder;
        public GameObject messagePrefab;*/
        void Start()
        {
         
        }

        public void OnSubmit()
        {
            _IP = inputField.GetComponent<Text>().text;
            _Port = inputField1.GetComponent<Text>().text;
            _nameText = NameInput.GetComponent<Text>().text;
            websocket = new WebSocket("ws://" + _IP + ":" + _Port + "/");
            //websocket = new WebSocket("ws://127.0.0.1:5500/");

            websocket.OnMessage += OnMessage;
            
            websocket.Connect();

            
        }

        public void OnSubmit2()
        {
            _Chat = ChatInPut.GetComponent<Text>().text;
            if (websocket.ReadyState == WebSocketState.Open)
            {
                websocket.Send(" "+_nameText+" : "+_Chat);

                
                
            }

        }
        void Update()
        {
            

        }

        private void OnDestroy()
        {
            if (websocket != null)
            {
                websocket.Close();
            }
        }

        
        public class Message
        {

            public string text;
            

        }
        public void OnMessage(object sender, MessageEventArgs messageEventArgs)
        {
            
            Debug.Log(messageEventArgs.Data);

            ChatMessage.GetComponent<Text>().text += messageEventArgs.Data+"\n";
            


        }

       

 

    }
}