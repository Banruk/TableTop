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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PortraitPane;
        private System.Windows.Forms.Panel ChatPane;
        private System.Windows.Forms.Panel GameGrid;
    }
}