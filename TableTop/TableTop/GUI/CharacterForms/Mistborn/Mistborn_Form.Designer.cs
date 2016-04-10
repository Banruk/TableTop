namespace TableTop.GUI.CharacterForms.Mistborn
{
    partial class Mistborn_Form
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
            this.CloseWindowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseWindowButton
            // 
            this.CloseWindowButton.Location = new System.Drawing.Point(1010, 12);
            this.CloseWindowButton.Name = "CloseWindowButton";
            this.CloseWindowButton.Size = new System.Drawing.Size(75, 23);
            this.CloseWindowButton.TabIndex = 0;
            this.CloseWindowButton.Text = "Close";
            this.CloseWindowButton.UseVisualStyleBackColor = true;
            // 
            // Mistborn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 791);
            this.Controls.Add(this.CloseWindowButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mistborn";
            this.Text = "Mistborn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseWindowButton;
    }
}