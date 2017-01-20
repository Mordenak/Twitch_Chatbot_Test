namespace TwitchChatbot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chatDisplay = new System.Windows.Forms.RichTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtChatroom = new System.Windows.Forms.TextBox();
            this.labelChatroom = new System.Windows.Forms.Label();
            this.labelConnectedChatroom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chatDisplay
            // 
            this.chatDisplay.Location = new System.Drawing.Point(41, 45);
            this.chatDisplay.Name = "chatDisplay";
            this.chatDisplay.Size = new System.Drawing.Size(313, 233);
            this.chatDisplay.TabIndex = 0;
            this.chatDisplay.Text = "";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(43, 287);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(152, 40);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(201, 287);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(152, 39);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtChatroom
            // 
            this.txtChatroom.Location = new System.Drawing.Point(42, 336);
            this.txtChatroom.Name = "txtChatroom";
            this.txtChatroom.Size = new System.Drawing.Size(152, 20);
            this.txtChatroom.TabIndex = 3;
            // 
            // labelChatroom
            // 
            this.labelChatroom.AutoSize = true;
            this.labelChatroom.Location = new System.Drawing.Point(207, 338);
            this.labelChatroom.Name = "labelChatroom";
            this.labelChatroom.Size = new System.Drawing.Size(52, 13);
            this.labelChatroom.TabIndex = 4;
            this.labelChatroom.Text = "Chatroom";
            // 
            // labelConnectedChatroom
            // 
            this.labelConnectedChatroom.AutoSize = true;
            this.labelConnectedChatroom.Location = new System.Drawing.Point(40, 20);
            this.labelConnectedChatroom.Name = "labelConnectedChatroom";
            this.labelConnectedChatroom.Size = new System.Drawing.Size(0, 13);
            this.labelConnectedChatroom.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 436);
            this.Controls.Add(this.labelConnectedChatroom);
            this.Controls.Add(this.labelChatroom);
            this.Controls.Add(this.txtChatroom);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.chatDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox chatDisplay;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox txtChatroom;
        private System.Windows.Forms.Label labelChatroom;
        private System.Windows.Forms.Label labelConnectedChatroom;
    }
}

