﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using T = System.Timers;

namespace SocketManager
{
    public class Client
    {
        private Guid _ID;
        private Socket _Sock;

        public Guid ID { get { return _ID; } }
        public Socket RemoteSocket { get { return _Sock; } set { _Sock = value; } }
        public byte[] RecieveBuffer = new byte[R.BUFFER_SIZE];

        public SocketError Errors;

        private T.Timer time;

        public Client(Socket s)
        {
            _ID = Guid.NewGuid();
            _Sock = s;
            time = new T.Timer(5000);
        }
    }
}
