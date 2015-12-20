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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.errorLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerIP
            // 
            this.ServerIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerIP.Location = new System.Drawing.Point(82, 60);
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Size = new System.Drawing.Size(570, 20);
            this.ServerIP.TabIndex = 2;
            this.ServerIP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(985, 651);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 3;
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
            this.isGM.Location = new System.Drawing.Point(405, 654);
            this.isGM.Name = "isGM";
            this.isGM.Size = new System.Drawing.Size(101, 17);
            this.isGM.TabIndex = 5;
            this.isGM.Text = "Connect As GM";
            this.isGM.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "User Name";
            // 
            // UserName
            // 
            this.UserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserName.Location = new System.Drawing.Point(82, 3);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(570, 20);
            this.UserName.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.21374F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.78626F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UserName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ServerIP, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Password, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(405, 485);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 85);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // Password
            // 
            this.Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Password.Location = new System.Drawing.Point(82, 31);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(570, 20);
            this.Password.TabIndex = 1;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(405, 602);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(35, 13);
            this.errorLbl.TabIndex = 9;
            this.errorLbl.Text = "label4";
            this.errorLbl.Visible = false;
            // 
            // ConnectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 862);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.isGM);
            this.Controls.Add(this.modeLbl);
            this.Controls.Add(this.ModeSelection);
            this.Controls.Add(this.ConnectButton);
            this.Name = "ConnectionWindow";
            this.Text = "ConnectionWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password;
        public System.Windows.Forms.Label errorLbl;
    }
}