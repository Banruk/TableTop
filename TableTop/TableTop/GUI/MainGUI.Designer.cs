namespace TableTop
{
    partial class MainGUI
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
            this.PortraitPane = new System.Windows.Forms.Panel();
            this.ChatPane = new System.Windows.Forms.Panel();
            this.GameGrid = new System.Windows.Forms.Panel();
            this.ChatWindow = new System.Windows.Forms.TextBox();
            this.ChatTypeSelector = new System.Windows.Forms.ComboBox();
            this.ChatInput = new System.Windows.Forms.TextBox();
            this.ChatButtonSubmit = new System.Windows.Forms.Button();
            this.ChatPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortraitPane
            // 
            this.PortraitPane.BackColor = System.Drawing.Color.DarkViolet;
            this.PortraitPane.Dock = System.Windows.Forms.DockStyle.Right;
            this.PortraitPane.Location = new System.Drawing.Point(1384, 0);
            this.PortraitPane.Name = "PortraitPane";
            this.PortraitPane.Size = new System.Drawing.Size(200, 862);
            this.PortraitPane.TabIndex = 0;
            // 
            // ChatPane
            // 
            this.ChatPane.BackColor = System.Drawing.Color.Black;
            this.ChatPane.Controls.Add(this.ChatButtonSubmit);
            this.ChatPane.Controls.Add(this.ChatInput);
            this.ChatPane.Controls.Add(this.ChatTypeSelector);
            this.ChatPane.Controls.Add(this.ChatWindow);
            this.ChatPane.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ChatPane.Location = new System.Drawing.Point(0, 625);
            this.ChatPane.Name = "ChatPane";
            this.ChatPane.Size = new System.Drawing.Size(1384, 237);
            this.ChatPane.TabIndex = 1;
            // 
            // GameGrid
            // 
            this.GameGrid.BackColor = System.Drawing.Color.ForestGreen;
            this.GameGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameGrid.Location = new System.Drawing.Point(0, 0);
            this.GameGrid.Name = "GameGrid";
            this.GameGrid.Size = new System.Drawing.Size(1384, 625);
            this.GameGrid.TabIndex = 2;
            // 
            // ChatWindow
            // 
            this.ChatWindow.Enabled = false;
            this.ChatWindow.Location = new System.Drawing.Point(3, 6);
            this.ChatWindow.Multiline = true;
            this.ChatWindow.Name = "ChatWindow";
            this.ChatWindow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatWindow.Size = new System.Drawing.Size(1375, 192);
            this.ChatWindow.TabIndex = 0;
            // 
            // ChatTypeSelector
            // 
            this.ChatTypeSelector.FormattingEnabled = true;
            this.ChatTypeSelector.Location = new System.Drawing.Point(12, 204);
            this.ChatTypeSelector.Name = "ChatTypeSelector";
            this.ChatTypeSelector.Size = new System.Drawing.Size(121, 21);
            this.ChatTypeSelector.TabIndex = 1;
            // 
            // ChatInput
            // 
            this.ChatInput.Location = new System.Drawing.Point(139, 205);
            this.ChatInput.Name = "ChatInput";
            this.ChatInput.Size = new System.Drawing.Size(1158, 20);
            this.ChatInput.TabIndex = 2;
            // 
            // ChatButtonSubmit
            // 
            this.ChatButtonSubmit.Location = new System.Drawing.Point(1303, 205);
            this.ChatButtonSubmit.Name = "ChatButtonSubmit";
            this.ChatButtonSubmit.Size = new System.Drawing.Size(75, 23);
            this.ChatButtonSubmit.TabIndex = 3;
            this.ChatButtonSubmit.Text = "Submit";
            this.ChatButtonSubmit.UseVisualStyleBackColor = true;
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 862);
            this.Controls.Add(this.GameGrid);
            this.Controls.Add(this.ChatPane);
            this.Controls.Add(this.PortraitPane);
            this.Name = "MainGUI";
            this.Text = "MainGUI";
            this.ChatPane.ResumeLayout(false);
            this.ChatPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PortraitPane;
        private System.Windows.Forms.Panel ChatPane;
        private System.Windows.Forms.Button ChatButtonSubmit;
        private System.Windows.Forms.TextBox ChatInput;
        private System.Windows.Forms.ComboBox ChatTypeSelector;
        private System.Windows.Forms.TextBox ChatWindow;
        private System.Windows.Forms.Panel GameGrid;
    }
}