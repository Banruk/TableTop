namespace CharacterTableTop.GUI.Portrait_Controls
{
    partial class Character_Form
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.LoadCharacterButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadPortraitButton = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PortraitWindow = new System.Windows.Forms.Panel();
            this.Weight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Race = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SpriteFileName = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(1010, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // LoadCharacterButton
            // 
            this.LoadCharacterButton.Location = new System.Drawing.Point(13, 12);
            this.LoadCharacterButton.Name = "LoadCharacterButton";
            this.LoadCharacterButton.Size = new System.Drawing.Size(118, 23);
            this.LoadCharacterButton.TabIndex = 2;
            this.LoadCharacterButton.Text = "Load Character";
            this.LoadCharacterButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1075, 746);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1067, 720);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Character Overview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(7, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1054, 476);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SpriteFileName);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Weight);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.LastName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LoadPortraitButton);
            this.panel1.Controls.Add(this.Description);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.PortraitWindow);
            this.panel1.Controls.Add(this.Height);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Age);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Gender);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Race);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FirstName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 225);
            this.panel1.TabIndex = 0;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(240, 38);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(150, 20);
            this.LastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // LoadPortraitButton
            // 
            this.LoadPortraitButton.Location = new System.Drawing.Point(4, 165);
            this.LoadPortraitButton.Name = "LoadPortraitButton";
            this.LoadPortraitButton.Size = new System.Drawing.Size(150, 23);
            this.LoadPortraitButton.TabIndex = 17;
            this.LoadPortraitButton.Text = "Load Portrait";
            this.LoadPortraitButton.UseVisualStyleBackColor = true;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(420, 38);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Description.Size = new System.Drawing.Size(629, 180);
            this.Description.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Description";
            // 
            // PortraitWindow
            // 
            this.PortraitWindow.BackColor = System.Drawing.Color.DarkRed;
            this.PortraitWindow.Location = new System.Drawing.Point(4, 8);
            this.PortraitWindow.Name = "PortraitWindow";
            this.PortraitWindow.Size = new System.Drawing.Size(150, 150);
            this.PortraitWindow.TabIndex = 14;
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(240, 146);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(150, 20);
            this.Weight.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Weight";
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(240, 172);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(150, 20);
            this.Height.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Height";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(240, 64);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(150, 20);
            this.Age.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Age";
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(240, 116);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(150, 20);
            this.Gender.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender";
            // 
            // Race
            // 
            this.Race.Location = new System.Drawing.Point(240, 90);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(150, 20);
            this.Race.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Race";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(240, 9);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(150, 20);
            this.FirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1067, 720);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inventory";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Load Sprite";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Sprite";
            // 
            // SpriteFileName
            // 
            this.SpriteFileName.AutoSize = true;
            this.SpriteFileName.Location = new System.Drawing.Point(240, 200);
            this.SpriteFileName.Name = "SpriteFileName";
            this.SpriteFileName.Size = new System.Drawing.Size(90, 13);
            this.SpriteFileName.TabIndex = 20;
            this.SpriteFileName.Text = "No Sprite Loaded";
            // 
            // Character_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LoadCharacterButton);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(150, 25);
            this.Name = "Character_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Character_Form";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button LoadCharacterButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel PortraitWindow;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Race;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadPortraitButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label SpriteFileName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}