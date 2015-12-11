namespace Chat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxYou = new System.Windows.Forms.GroupBox();
            this.label_Port1 = new System.Windows.Forms.Label();
            this.label_IP1 = new System.Windows.Forms.Label();
            this.textBox_Port1 = new System.Windows.Forms.TextBox();
            this.textBox_IP1 = new System.Windows.Forms.TextBox();
            this.groupBoxFriend = new System.Windows.Forms.GroupBox();
            this.label_Port2 = new System.Windows.Forms.Label();
            this.label_IP2 = new System.Windows.Forms.Label();
            this.textBox_Port2 = new System.Windows.Forms.TextBox();
            this.textBox_IP2 = new System.Windows.Forms.TextBox();
            this.listBox_chat = new System.Windows.Forms.ListBox();
            this.textBox_toSend = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCurrentToBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comingSoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxYou.SuspendLayout();
            this.groupBoxFriend.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxYou
            // 
            this.groupBoxYou.Controls.Add(this.label_Port1);
            this.groupBoxYou.Controls.Add(this.label_IP1);
            this.groupBoxYou.Controls.Add(this.textBox_Port1);
            this.groupBoxYou.Controls.Add(this.textBox_IP1);
            this.groupBoxYou.Location = new System.Drawing.Point(12, 27);
            this.groupBoxYou.Name = "groupBoxYou";
            this.groupBoxYou.Size = new System.Drawing.Size(200, 100);
            this.groupBoxYou.TabIndex = 0;
            this.groupBoxYou.TabStop = false;
            this.groupBoxYou.Text = "You";
            // 
            // label_Port1
            // 
            this.label_Port1.AutoSize = true;
            this.label_Port1.Location = new System.Drawing.Point(16, 60);
            this.label_Port1.Name = "label_Port1";
            this.label_Port1.Size = new System.Drawing.Size(29, 13);
            this.label_Port1.TabIndex = 3;
            this.label_Port1.Text = "Port:";
            // 
            // label_IP1
            // 
            this.label_IP1.AutoSize = true;
            this.label_IP1.Location = new System.Drawing.Point(16, 31);
            this.label_IP1.Name = "label_IP1";
            this.label_IP1.Size = new System.Drawing.Size(20, 13);
            this.label_IP1.TabIndex = 2;
            this.label_IP1.Text = "IP:";
            // 
            // textBox_Port1
            // 
            this.textBox_Port1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Port1.Location = new System.Drawing.Point(61, 58);
            this.textBox_Port1.Name = "textBox_Port1";
            this.textBox_Port1.Size = new System.Drawing.Size(133, 20);
            this.textBox_Port1.TabIndex = 1;
            // 
            // textBox_IP1
            // 
            this.textBox_IP1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_IP1.Location = new System.Drawing.Point(61, 28);
            this.textBox_IP1.Name = "textBox_IP1";
            this.textBox_IP1.Size = new System.Drawing.Size(133, 20);
            this.textBox_IP1.TabIndex = 0;
            // 
            // groupBoxFriend
            // 
            this.groupBoxFriend.Controls.Add(this.label_Port2);
            this.groupBoxFriend.Controls.Add(this.label_IP2);
            this.groupBoxFriend.Controls.Add(this.textBox_Port2);
            this.groupBoxFriend.Controls.Add(this.textBox_IP2);
            this.groupBoxFriend.Location = new System.Drawing.Point(218, 27);
            this.groupBoxFriend.Name = "groupBoxFriend";
            this.groupBoxFriend.Size = new System.Drawing.Size(200, 100);
            this.groupBoxFriend.TabIndex = 1;
            this.groupBoxFriend.TabStop = false;
            this.groupBoxFriend.Text = "Friend";
            // 
            // label_Port2
            // 
            this.label_Port2.AutoSize = true;
            this.label_Port2.Location = new System.Drawing.Point(16, 61);
            this.label_Port2.Name = "label_Port2";
            this.label_Port2.Size = new System.Drawing.Size(29, 13);
            this.label_Port2.TabIndex = 3;
            this.label_Port2.Text = "Port:";
            // 
            // label_IP2
            // 
            this.label_IP2.AutoSize = true;
            this.label_IP2.Location = new System.Drawing.Point(16, 31);
            this.label_IP2.Name = "label_IP2";
            this.label_IP2.Size = new System.Drawing.Size(20, 13);
            this.label_IP2.TabIndex = 2;
            this.label_IP2.Text = "IP:";
            // 
            // textBox_Port2
            // 
            this.textBox_Port2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Port2.Location = new System.Drawing.Point(61, 57);
            this.textBox_Port2.Name = "textBox_Port2";
            this.textBox_Port2.Size = new System.Drawing.Size(133, 20);
            this.textBox_Port2.TabIndex = 1;
            // 
            // textBox_IP2
            // 
            this.textBox_IP2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_IP2.Location = new System.Drawing.Point(61, 28);
            this.textBox_IP2.Name = "textBox_IP2";
            this.textBox_IP2.Size = new System.Drawing.Size(133, 20);
            this.textBox_IP2.TabIndex = 0;
            // 
            // listBox_chat
            // 
            this.listBox_chat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_chat.FormattingEnabled = true;
            this.listBox_chat.Location = new System.Drawing.Point(12, 133);
            this.listBox_chat.Name = "listBox_chat";
            this.listBox_chat.Size = new System.Drawing.Size(487, 225);
            this.listBox_chat.TabIndex = 2;
            // 
            // textBox_toSend
            // 
            this.textBox_toSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_toSend.Location = new System.Drawing.Point(12, 364);
            this.textBox_toSend.Name = "textBox_toSend";
            this.textBox_toSend.Size = new System.Drawing.Size(406, 20);
            this.textBox_toSend.TabIndex = 3;
            this.textBox_toSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_toSend_KeyPress);
            // 
            // button_Send
            // 
            this.button_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Send.Location = new System.Drawing.Point(424, 361);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 4;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(424, 53);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_Connect.TabIndex = 5;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Location = new System.Drawing.Point(424, 82);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.button_Disconnect.TabIndex = 6;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.bookmarksToolStripMenuItem,
            this.encryptionToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.connectionToolStripMenuItem.Text = "Connections";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+D";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // bookmarksToolStripMenuItem
            // 
            this.bookmarksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCurrentToBookmarksToolStripMenuItem,
            this.bookmarkListToolStripMenuItem});
            this.bookmarksToolStripMenuItem.Name = "bookmarksToolStripMenuItem";
            this.bookmarksToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.bookmarksToolStripMenuItem.Text = "Bookmarks";
            // 
            // addCurrentToBookmarksToolStripMenuItem
            // 
            this.addCurrentToBookmarksToolStripMenuItem.Name = "addCurrentToBookmarksToolStripMenuItem";
            this.addCurrentToBookmarksToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.addCurrentToBookmarksToolStripMenuItem.Text = "Add current to bookmarks";
            // 
            // bookmarkListToolStripMenuItem
            // 
            this.bookmarkListToolStripMenuItem.Name = "bookmarkListToolStripMenuItem";
            this.bookmarkListToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+B";
            this.bookmarkListToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.bookmarkListToolStripMenuItem.Text = "Bookmark list";
            this.bookmarkListToolStripMenuItem.Click += new System.EventHandler(this.bookmarkListToolStripMenuItem_Click);
            // 
            // encryptionToolStripMenuItem
            // 
            this.encryptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comingSoonToolStripMenuItem});
            this.encryptionToolStripMenuItem.Name = "encryptionToolStripMenuItem";
            this.encryptionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.encryptionToolStripMenuItem.Text = "Encryption";
            // 
            // comingSoonToolStripMenuItem
            // 
            this.comingSoonToolStripMenuItem.Name = "comingSoonToolStripMenuItem";
            this.comingSoonToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.comingSoonToolStripMenuItem.Text = "Coming soon...";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.ShortcutKeyDisplayString = "F1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem1.Text = "View Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 393);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(513, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 415);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_Disconnect);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_toSend);
            this.Controls.Add(this.listBox_chat);
            this.Controls.Add(this.groupBoxFriend);
            this.Controls.Add(this.groupBoxYou);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(529, 453);
            this.Name = "Form1";
            this.Text = "Direct Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBoxYou.ResumeLayout(false);
            this.groupBoxYou.PerformLayout();
            this.groupBoxFriend.ResumeLayout(false);
            this.groupBoxFriend.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxYou;
        private System.Windows.Forms.Label label_Port1;
        private System.Windows.Forms.Label label_IP1;
        private System.Windows.Forms.TextBox textBox_Port1;
        private System.Windows.Forms.TextBox textBox_IP1;
        private System.Windows.Forms.GroupBox groupBoxFriend;
        private System.Windows.Forms.Label label_Port2;
        private System.Windows.Forms.Label label_IP2;
        private System.Windows.Forms.TextBox textBox_Port2;
        private System.Windows.Forms.TextBox textBox_IP2;
        private System.Windows.Forms.ListBox listBox_chat;
        private System.Windows.Forms.TextBox textBox_toSend;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookmarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comingSoonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addCurrentToBookmarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookmarkListToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
    }
}

