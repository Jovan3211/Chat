namespace Chat
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Encryption = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_BlockConn = new System.Windows.Forms.TabPage();
            this.tabPage_General = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_autoSaveChat = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_nick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_recieveMessSound = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_Encryption.SuspendLayout();
            this.tabPage_BlockConn.SuspendLayout();
            this.tabPage_General.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage_General);
            this.tabControl1.Controls.Add(this.tabPage_Encryption);
            this.tabControl1.Controls.Add(this.tabPage_BlockConn);
            this.tabControl1.Location = new System.Drawing.Point(-3, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(340, 386);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Encryption
            // 
            this.tabPage_Encryption.Controls.Add(this.label1);
            this.tabPage_Encryption.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Encryption.Name = "tabPage_Encryption";
            this.tabPage_Encryption.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Encryption.Size = new System.Drawing.Size(332, 360);
            this.tabPage_Encryption.TabIndex = 1;
            this.tabPage_Encryption.Text = "Encryption";
            this.tabPage_Encryption.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coming soon...";
            // 
            // tabPage_BlockConn
            // 
            this.tabPage_BlockConn.Controls.Add(this.label3);
            this.tabPage_BlockConn.Location = new System.Drawing.Point(4, 22);
            this.tabPage_BlockConn.Name = "tabPage_BlockConn";
            this.tabPage_BlockConn.Size = new System.Drawing.Size(332, 360);
            this.tabPage_BlockConn.TabIndex = 2;
            this.tabPage_BlockConn.Text = "Block connections";
            this.tabPage_BlockConn.UseVisualStyleBackColor = true;
            // 
            // tabPage_General
            // 
            this.tabPage_General.Controls.Add(this.checkBox_recieveMessSound);
            this.tabPage_General.Controls.Add(this.label2);
            this.tabPage_General.Controls.Add(this.textBox_nick);
            this.tabPage_General.Controls.Add(this.checkBox_autoSaveChat);
            this.tabPage_General.Location = new System.Drawing.Point(4, 22);
            this.tabPage_General.Name = "tabPage_General";
            this.tabPage_General.Size = new System.Drawing.Size(332, 360);
            this.tabPage_General.TabIndex = 3;
            this.tabPage_General.Text = "General";
            this.tabPage_General.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(97, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Coming soon...";
            // 
            // checkBox_autoSaveChat
            // 
            this.checkBox_autoSaveChat.AutoSize = true;
            this.checkBox_autoSaveChat.Location = new System.Drawing.Point(14, 35);
            this.checkBox_autoSaveChat.Name = "checkBox_autoSaveChat";
            this.checkBox_autoSaveChat.Size = new System.Drawing.Size(155, 17);
            this.checkBox_autoSaveChat.TabIndex = 0;
            this.checkBox_autoSaveChat.Text = "Automatically save chat log";
            this.checkBox_autoSaveChat.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_nick
            // 
            this.textBox_nick.Location = new System.Drawing.Point(74, 9);
            this.textBox_nick.Name = "textBox_nick";
            this.textBox_nick.Size = new System.Drawing.Size(138, 20);
            this.textBox_nick.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nickname:";
            // 
            // checkBox_recieveMessSound
            // 
            this.checkBox_recieveMessSound.AutoSize = true;
            this.checkBox_recieveMessSound.Checked = true;
            this.checkBox_recieveMessSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_recieveMessSound.Location = new System.Drawing.Point(14, 58);
            this.checkBox_recieveMessSound.Name = "checkBox_recieveMessSound";
            this.checkBox_recieveMessSound.Size = new System.Drawing.Size(143, 17);
            this.checkBox_recieveMessSound.TabIndex = 3;
            this.checkBox_recieveMessSound.Text = "Recieve message sound";
            this.checkBox_recieveMessSound.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Encryption.ResumeLayout(false);
            this.tabPage_Encryption.PerformLayout();
            this.tabPage_BlockConn.ResumeLayout(false);
            this.tabPage_BlockConn.PerformLayout();
            this.tabPage_General.ResumeLayout(false);
            this.tabPage_General.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Encryption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_BlockConn;
        private System.Windows.Forms.TabPage tabPage_General;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_autoSaveChat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nick;
        private System.Windows.Forms.CheckBox checkBox_recieveMessSound;
    }
}