namespace TableTop.GUI.CharacterForms
{
    partial class CharacterSelection
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
            this.CharacterSelectionBox = new System.Windows.Forms.ListBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CharacterSelectionBox
            // 
            this.CharacterSelectionBox.FormattingEnabled = true;
            this.CharacterSelectionBox.Location = new System.Drawing.Point(12, 19);
            this.CharacterSelectionBox.Name = "CharacterSelectionBox";
            this.CharacterSelectionBox.Size = new System.Drawing.Size(1076, 732);
            this.CharacterSelectionBox.TabIndex = 0;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(439, 765);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(590, 765);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // CharacterSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.CharacterSelectionBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CharacterSelection";
            this.Text = "CharacterSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CharacterSelectionBox;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button CancelButton;
    }
}