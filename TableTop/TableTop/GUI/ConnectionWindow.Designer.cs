namespace TableTop
{
    partial class ConnectionWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param FirstName="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.ServerIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ModeSelection = new System.Windows.Forms.ComboBox();
            this.modeLbl = new System.Windows.Forms.Label();
            this.isGM = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ServerIP
            // 
            this.ServerIP.Location = new System.Drawing.Point(478, 604);
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Size = new System.Drawing.Size(480, 20);
            this.ServerIP.TabIndex = 0;
            this.ServerIP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 607);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(981, 601);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            // 
            // ModeSelection
            // 
            this.ModeSelection.FormattingEnabled = true;
            this.ModeSelection.Location = new System.Drawing.Point(696, 652);
            this.ModeSelection.Name = "ModeSelection";
            this.ModeSelection.Size = new System.Drawing.Size(188, 21);
            this.ModeSelection.TabIndex = 3;
            this.ModeSelection.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // modeLbl
            // 
            this.modeLbl.AutoSize = true;
            this.modeLbl.Location = new System.Drawing.Point(588, 656);
            this.modeLbl.Name = "modeLbl";
            this.modeLbl.Size = new System.Drawing.Size(82, 13);
            this.modeLbl.TabIndex = 4;
            this.modeLbl.Text = "Game Selection";
            // 
            // isGM
            // 
            this.isGM.AutoSize = true;
            this.isGM.Location = new System.Drawing.Point(401, 656);
            this.isGM.Name = "isGM";
            this.isGM.Size = new System.Drawing.Size(101, 17);
            this.isGM.TabIndex = 5;
            this.isGM.Text = "Connect As GM";
            this.isGM.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "User Name";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(478, 562);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(480, 20);
            this.UserName.TabIndex = 7;
            // 
            // ConnectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 862);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isGM);
            this.Controls.Add(this.modeLbl);
            this.Controls.Add(this.ModeSelection);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServerIP);
            this.Name = "ConnectionWindow";
            this.Text = "ConnectionWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ServerIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.ComboBox ModeSelection;
        private System.Windows.Forms.Label modeLbl;
        private System.Windows.Forms.CheckBox isGM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserName;
    }
}