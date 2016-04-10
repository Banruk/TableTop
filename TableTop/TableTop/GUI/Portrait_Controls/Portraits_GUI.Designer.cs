namespace TableTop.GUI
{
    partial class Portraits_GUI
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
            this.PortraitPane = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // PortraitPane
            // 
            this.PortraitPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PortraitPane.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PortraitPane.Location = new System.Drawing.Point(0, 0);
            this.PortraitPane.Name = "PortraitPane";
            this.PortraitPane.Size = new System.Drawing.Size(184, 824);
            this.PortraitPane.TabIndex = 0;
            this.PortraitPane.WrapContents = false;
            // 
            // Portraits_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 824);
            this.Controls.Add(this.PortraitPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Portraits";
            this.Text = "PortraitPane";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.FlowLayoutPanel PortraitPane;


    }
}