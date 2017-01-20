using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchLib;
using TwitchLib.Models.API;
using TwitchLib.Models.Client;
using TwitchLib.Events.Client;
using TwitchLib.Exceptions.API;
using TwitchLib.Events.PubSub;
using TwitchLib.Events.Services.FollowerService;
using TwitchLib.Events.Services.MessageThrottler;
using TwitchLib.Enums;
using TwitchLib.Extensions.Client;

namespace TwitchChatbot
{
    public partial class Form1 : Form
    {
        public TwitchClient client = new TwitchClient(new TwitchLib.Models.Client.ConnectionCredentials(Properties.Settings.Default.username, Properties.Settings.Default.oauth));
        public String lastChatroom = "";

        public Form1()
        {
            InitializeComponent();

            client.OnConnected += new EventHandler<OnConnectedArgs>(onConnected);
            client.OnDisconnected += new EventHandler<OnDisconnectedArgs>(onDisconnected);
            client.OnMessageReceived += new EventHandler<OnMessageReceivedArgs>(globalChatMessageReceived);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!client.IsConnected && txtChatroom.Text != "")
            {
                client.Connect();

                updateChatDisplay("Connecting...");
            }
            else if (txtChatroom.Text == "")
            {
                updateChatDisplay("Please enter a chatroom.");
            }
            else
            {
                updateChatDisplay("Already connected.");
            }
            
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                if (lastChatroom != "")
                {
                    client.LeaveChannel(lastChatroom);
                }
                client.Disconnect();

                updateChatDisplay("Disconnecting...");
            }
            else
            {
                updateChatDisplay("Not connected.");
            }
        }

        public void onConnected(object sender, OnConnectedArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            client.JoinChannel(txtChatroom.Text);
            lastChatroom = txtChatroom.Text;

            updateChatDisplay("<< Connected to " + txtChatroom.Text + " chat server >>");
            updateChatLabel(txtChatroom.Text);
            
        }

        public void onDisconnected(object sender, OnDisconnectedArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            updateChatDisplay("<< Disconnected from chat >>");
            updateChatLabel("");
        }

        public void globalChatMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            updateChatDisplay(e.ChatMessage.Username + ": " + e.ChatMessage.Message);
        }

        public void updateChatDisplay(string message)
        {
            chatDisplay.Text = chatDisplay.Text + "\n" + message;
            chatDisplay.SelectionStart = chatDisplay.Text.Length;
            chatDisplay.ScrollToCaret();
        }

        public void updateChatLabel(string message)
        {
            if (message != "")
            {
                labelConnectedChatroom.Text = message + "'s chat";
            }
            else
            {
                labelConnectedChatroom.Text = "";
            }
            
        }

    }
}
