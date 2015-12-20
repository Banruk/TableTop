namespace TableTop.GUI
{
    partial class BottomSection
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
            this.BottomContentPane = new System.Windows.Forms.Panel();
            this.BottomTab = new System.Windows.Forms.TabControl();
            this.chatTab = new System.Windows.Forms.TabPage();
            this.ChatWindow = new System.Windows.Forms.RichTextBox();
            this.ChatSubmit = new System.Windows.Forms.Button();
            this.ChatInput = new System.Windows.Forms.TextBox();
            this.ChatTypeSelector = new System.Windows.Forms.ComboBox();
            this.UserControlsTab = new System.Windows.Forms.TabPage();
            this.DownloadStoryButton = new System.Windows.Forms.Button();
            this.GMTab = new System.Windows.Forms.TabPage();
            this.MapControlsButton = new System.Windows.Forms.Button();
            this.NPControlsButton = new System.Windows.Forms.Button();
            this.BottomContentPane.SuspendLayout();
            this.BottomTab.SuspendLayout();
            this.chatTab.SuspendLayout();
            this.UserControlsTab.SuspendLayout();
            this.GMTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomContentPane
            // 
            this.BottomContentPane.Controls.Add(this.BottomTab);
            this.BottomContentPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomContentPane.Location = new System.Drawing.Point(0, 0);
            this.BottomContentPane.Name = "BottomContentPane";
            this.BottomContentPane.Size = new System.Drawing.Size(1385, 240);
            this.BottomContentPane.TabIndex = 0;
            // 
            // BottomTab
            // 
            this.BottomTab.Controls.Add(this.chatTab);
            this.BottomTab.Controls.Add(this.UserControlsTab);
            this.BottomTab.Controls.Add(this.GMTab);
            this.BottomTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomTab.Location = new System.Drawing.Point(0, 0);
            this.BottomTab.Name = "BottomTab";
            this.BottomTab.SelectedIndex = 0;
            this.BottomTab.Size = new System.Drawing.Size(1385, 240);
            this.BottomTab.TabIndex = 0;
            // 
            // chatTab
            // 
            this.chatTab.BackColor = System.Drawing.Color.Transparent;
            this.chatTab.Controls.Add(this.ChatWindow);
            this.chatTab.Controls.Add(this.ChatSubmit);
            this.chatTab.Controls.Add(this.ChatInput);
            this.chatTab.Controls.Add(this.ChatTypeSelector);
            this.chatTab.Location = new System.Drawing.Point(4, 22);
            this.chatTab.Name = "chatTab";
            this.chatTab.Padding = new System.Windows.Forms.Padding(3);
            this.chatTab.Size = new System.Drawing.Size(1377, 214);
            this.chatTab.TabIndex = 0;
            this.chatTab.Text = "Chat Window";
            this.chatTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // ChatWindow
            // 
            this.ChatWindow.Location = new System.Drawing.Point(9, 7);
            this.ChatWindow.Name = "ChatWindow";
            this.ChatWindow.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ChatWindow.Size = new System.Drawing.Size(1360, 171);
            this.ChatWindow.TabIndex = 4;
            this.ChatWindow.Text = "";
            // 
            // ChatSubmit
            // 
            this.ChatSubmit.Location = new System.Drawing.Point(1216, 184);
            this.ChatSubmit.Name = "ChatSubmit";
            this.ChatSubmit.Size = new System.Drawing.Size(153, 23);
            this.ChatSubmit.TabIndex = 3;
            this.ChatSubmit.Text = "Submit";
            this.ChatSubmit.UseVisualStyleBackColor = true;
            // 
            // ChatInput
            // 
            this.ChatInput.Location = new System.Drawing.Point(166, 185);
            this.ChatInput.Name = "ChatInput";
            this.ChatInput.Size = new System.Drawing.Size(1044, 20);
            this.ChatInput.TabIndex = 2;
            // 
            // ChatTypeSelector
            // 
            this.ChatTypeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChatTypeSelector.FormattingEnabled = true;
            this.ChatTypeSelector.Location = new System.Drawing.Point(9, 184);
            this.ChatTypeSelector.Name = "ChatTypeSelector";
            this.ChatTypeSelector.Size = new System.Drawing.Size(151, 21);
            this.ChatTypeSelector.TabIndex = 1;
            // 
            // UserControlsTab
            // 
            this.UserControlsTab.Controls.Add(this.DownloadStoryButton);
            this.UserControlsTab.Location = new System.Drawing.Point(4, 22);
            this.UserControlsTab.Name = "UserControlsTab";
            this.UserControlsTab.Padding = new System.Windows.Forms.Padding(3);
            this.UserControlsTab.Size = new System.Drawing.Size(1377, 214);
            this.UserControlsTab.TabIndex = 1;
            this.UserControlsTab.Text = "User Controls";
            this.UserControlsTab.UseVisualStyleBackColor = true;
            // 
            // DownloadStoryButton
            // 
            this.DownloadStoryButton.Location = new System.Drawing.Point(9, 7);
            this.DownloadStoryButton.Name = "DownloadStoryButton";
            this.DownloadStoryButton.Size = new System.Drawing.Size(105, 23);
            this.DownloadStoryButton.TabIndex = 0;
            this.DownloadStoryButton.Text = "Download Story";
            this.DownloadStoryButton.UseVisualStyleBackColor = true;
            // 
            // GMTab
            // 
            this.GMTab.Controls.Add(this.MapControlsButton);
            this.GMTab.Controls.Add(this.NPControlsButton);
            this.GMTab.Location = new System.Drawing.Point(4, 22);
            this.GMTab.Name = "GMTab";
            this.GMTab.Padding = new System.Windows.Forms.Padding(3);
            this.GMTab.Size = new System.Drawing.Size(1377, 214);
            this.GMTab.TabIndex = 2;
            this.GMTab.Text = "GM Tools";
            this.GMTab.UseVisualStyleBackColor = true;
            // 
            // MapControlsButton
            // 
            this.MapControlsButton.Location = new System.Drawing.Point(8, 35);
            this.MapControlsButton.Name = "MapControlsButton";
            this.MapControlsButton.Size = new System.Drawing.Size(100, 23);
            this.MapControlsButton.TabIndex = 1;
            this.MapControlsButton.Text = "Map Controls";
            this.MapControlsButton.UseVisualStyleBackColor = true;
            // 
            // NPControlsButton
            // 
            this.NPControlsButton.Location = new System.Drawing.Point(6, 6);
            this.NPControlsButton.Name = "NPControlsButton";
            this.NPControlsButton.Size = new System.Drawing.Size(102, 23);
            this.NPControlsButton.TabIndex = 0;
            this.NPControlsButton.Text = "NPC Controls";
            this.NPControlsButton.UseVisualStyleBackColor = true;
            // 
            // BottomSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 240);
            this.Controls.Add(this.BottomContentPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BottomSection";
            this.Text = "BottomSection";
            this.BottomContentPane.ResumeLayout(false);
            this.BottomTab.ResumeLayout(false);
            this.chatTab.ResumeLayout(false);
            this.chatTab.PerformLayout();
            this.UserControlsTab.ResumeLayout(false);
            this.GMTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BottomContentPane;
        private System.Windows.Forms.TabControl BottomTab;
        private System.Windows.Forms.TabPage chatTab;
        private System.Windows.Forms.TabPage UserControlsTab;
        private System.Windows.Forms.Button ChatSubmit;
        private System.Windows.Forms.TextBox ChatInput;
        private System.Windows.Forms.ComboBox ChatTypeSelector;
        private System.Windows.Forms.TabPage GMTab;
        private System.Windows.Forms.Button MapControlsButton;
        private System.Windows.Forms.Button NPControlsButton;
        private System.Windows.Forms.Button DownloadStoryButton;
        private System.Windows.Forms.RichTextBox ChatWindow;
    }
}