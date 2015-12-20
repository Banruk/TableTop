namespace MapEditor
{
    partial class MapEditor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.saveMapButton = new System.Windows.Forms.Button();
            this.loadMapButton = new System.Windows.Forms.Button();
            this.createMapButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sizeYInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sizeXInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BackgroundPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mapScreen = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.enterableTop = new System.Windows.Forms.CheckBox();
            this.enterableBottom = new System.Windows.Forms.CheckBox();
            this.enterableLeft = new System.Windows.Forms.CheckBox();
            this.enterableRight = new System.Windows.Forms.CheckBox();
            this.canGoUp = new System.Windows.Forms.CheckBox();
            this.canGoDown = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rotateRight = new System.Windows.Forms.Button();
            this.rotateLeft = new System.Windows.Forms.Button();
            this.selectedTile = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 687);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1559, 163);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Controls.Add(this.createMapButton);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1551, 137);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Controls";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.saveMapButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.loadMapButton, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1345, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 58);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // saveMapButton
            // 
            this.saveMapButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveMapButton.Location = new System.Drawing.Point(3, 3);
            this.saveMapButton.Name = "saveMapButton";
            this.saveMapButton.Size = new System.Drawing.Size(194, 23);
            this.saveMapButton.TabIndex = 0;
            this.saveMapButton.Text = "Save Map";
            this.saveMapButton.UseVisualStyleBackColor = true;
            // 
            // loadMapButton
            // 
            this.loadMapButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadMapButton.Location = new System.Drawing.Point(3, 32);
            this.loadMapButton.Name = "loadMapButton";
            this.loadMapButton.Size = new System.Drawing.Size(194, 23);
            this.loadMapButton.TabIndex = 1;
            this.loadMapButton.Text = "Load Map";
            this.loadMapButton.UseVisualStyleBackColor = true;
            // 
            // createMapButton
            // 
            this.createMapButton.Location = new System.Drawing.Point(7, 72);
            this.createMapButton.Name = "createMapButton";
            this.createMapButton.Size = new System.Drawing.Size(197, 23);
            this.createMapButton.TabIndex = 1;
            this.createMapButton.Text = "Initialize Map";
            this.createMapButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.5F));
            this.tableLayoutPanel1.Controls.Add(this.sizeYInput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.sizeXInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 58);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // sizeYInput
            // 
            this.sizeYInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizeYInput.Location = new System.Drawing.Point(40, 32);
            this.sizeYInput.Name = "sizeYInput";
            this.sizeYInput.Size = new System.Drawing.Size(157, 20);
            this.sizeYInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // sizeXInput
            // 
            this.sizeXInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizeXInput.Location = new System.Drawing.Point(40, 3);
            this.sizeXInput.Name = "sizeXInput";
            this.sizeXInput.Size = new System.Drawing.Size(157, 20);
            this.sizeXInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BackgroundPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1551, 137);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tiles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(3, 3);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(1545, 131);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // mapScreen
            // 
            this.mapScreen.AutoScroll = true;
            this.mapScreen.Location = new System.Drawing.Point(13, 12);
            this.mapScreen.Name = "mapScreen";
            this.mapScreen.Size = new System.Drawing.Size(1349, 669);
            this.mapScreen.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectedTile);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(1368, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 668);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.enterableTop);
            this.flowLayoutPanel1.Controls.Add(this.enterableBottom);
            this.flowLayoutPanel1.Controls.Add(this.enterableLeft);
            this.flowLayoutPanel1.Controls.Add(this.enterableRight);
            this.flowLayoutPanel1.Controls.Add(this.canGoUp);
            this.flowLayoutPanel1.Controls.Add(this.canGoDown);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 120);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(193, 208);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // enterableTop
            // 
            this.enterableTop.AutoSize = true;
            this.enterableTop.Location = new System.Drawing.Point(3, 37);
            this.enterableTop.Name = "enterableTop";
            this.enterableTop.Size = new System.Drawing.Size(93, 17);
            this.enterableTop.TabIndex = 0;
            this.enterableTop.Text = "Enterable Top";
            this.enterableTop.UseVisualStyleBackColor = true;
            // 
            // enterableBottom
            // 
            this.enterableBottom.AutoSize = true;
            this.enterableBottom.Location = new System.Drawing.Point(3, 60);
            this.enterableBottom.Name = "enterableBottom";
            this.enterableBottom.Size = new System.Drawing.Size(107, 17);
            this.enterableBottom.TabIndex = 1;
            this.enterableBottom.Text = "Enterable Bottom";
            this.enterableBottom.UseVisualStyleBackColor = true;
            // 
            // enterableLeft
            // 
            this.enterableLeft.AutoSize = true;
            this.enterableLeft.Location = new System.Drawing.Point(3, 83);
            this.enterableLeft.Name = "enterableLeft";
            this.enterableLeft.Size = new System.Drawing.Size(92, 17);
            this.enterableLeft.TabIndex = 2;
            this.enterableLeft.Text = "Enterable Left";
            this.enterableLeft.UseVisualStyleBackColor = true;
            // 
            // enterableRight
            // 
            this.enterableRight.AutoSize = true;
            this.enterableRight.Location = new System.Drawing.Point(3, 106);
            this.enterableRight.Name = "enterableRight";
            this.enterableRight.Size = new System.Drawing.Size(99, 17);
            this.enterableRight.TabIndex = 3;
            this.enterableRight.Text = "Enterable Right";
            this.enterableRight.UseVisualStyleBackColor = true;
            // 
            // canGoUp
            // 
            this.canGoUp.AutoSize = true;
            this.canGoUp.Location = new System.Drawing.Point(3, 129);
            this.canGoUp.Name = "canGoUp";
            this.canGoUp.Size = new System.Drawing.Size(79, 17);
            this.canGoUp.TabIndex = 4;
            this.canGoUp.Text = "Can Go Up";
            this.canGoUp.UseVisualStyleBackColor = true;
            // 
            // canGoDown
            // 
            this.canGoDown.AutoSize = true;
            this.canGoDown.Location = new System.Drawing.Point(3, 152);
            this.canGoDown.Name = "canGoDown";
            this.canGoDown.Size = new System.Drawing.Size(93, 17);
            this.canGoDown.TabIndex = 5;
            this.canGoDown.Text = "Can Go Down";
            this.canGoDown.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.rotateRight, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rotateLeft, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(190, 28);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // rotateRight
            // 
            this.rotateRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotateRight.Location = new System.Drawing.Point(3, 3);
            this.rotateRight.Name = "rotateRight";
            this.rotateRight.Size = new System.Drawing.Size(89, 22);
            this.rotateRight.TabIndex = 0;
            this.rotateRight.Text = "R 90";
            this.rotateRight.UseVisualStyleBackColor = true;
            // 
            // rotateLeft
            // 
            this.rotateLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotateLeft.Location = new System.Drawing.Point(98, 3);
            this.rotateLeft.Name = "rotateLeft";
            this.rotateLeft.Size = new System.Drawing.Size(89, 22);
            this.rotateLeft.TabIndex = 1;
            this.rotateLeft.Text = "L 90";
            this.rotateLeft.UseVisualStyleBackColor = true;
            // 
            // selectedTile
            // 
            this.selectedTile.Location = new System.Drawing.Point(48, 3);
            this.selectedTile.Name = "selectedTile";
            this.selectedTile.Size = new System.Drawing.Size(100, 100);
            this.selectedTile.TabIndex = 1;
            // 
            // MapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 862);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mapScreen);
            this.Controls.Add(this.tabControl1);
            this.Name = "MapEditor";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button saveMapButton;
        private System.Windows.Forms.Button loadMapButton;
        private System.Windows.Forms.Button createMapButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox sizeYInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sizeXInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel mapScreen;
        private System.Windows.Forms.FlowLayoutPanel BackgroundPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox enterableTop;
        private System.Windows.Forms.CheckBox enterableBottom;
        private System.Windows.Forms.CheckBox enterableLeft;
        private System.Windows.Forms.CheckBox enterableRight;
        private System.Windows.Forms.CheckBox canGoUp;
        private System.Windows.Forms.CheckBox canGoDown;
        private System.Windows.Forms.Panel selectedTile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button rotateRight;
        private System.Windows.Forms.Button rotateLeft;
    }
}

