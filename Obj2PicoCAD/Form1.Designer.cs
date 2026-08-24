namespace Obj2PicoCAD
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            bgBtn = new Button();
            alphaBtn = new Button();
            label10 = new Label();
            label9 = new Label();
            zoomLevel = new NumericUpDown();
            label8 = new Label();
            rotZ = new NumericUpDown();
            rotY = new NumericUpDown();
            rotX = new NumericUpDown();
            sizeInput = new NumericUpDown();
            posZ = new NumericUpDown();
            posY = new NumericUpDown();
            posX = new NumericUpDown();
            exportButton = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            backMeshMode = new RadioButton();
            label3 = new Label();
            frontMeshMode = new RadioButton();
            label2 = new Label();
            exportBrowseBtn = new Button();
            exportPathTextInput = new TextBox();
            label1 = new Label();
            objBrowseBtn = new Button();
            objPathTextInput = new TextBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            clearButton = new Button();
            recentListBox = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)zoomLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rotZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rotY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rotX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sizeInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)posZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)posY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)posX).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bgBtn);
            groupBox1.Controls.Add(alphaBtn);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(zoomLevel);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(rotZ);
            groupBox1.Controls.Add(rotY);
            groupBox1.Controls.Add(rotX);
            groupBox1.Controls.Add(sizeInput);
            groupBox1.Controls.Add(posZ);
            groupBox1.Controls.Add(posY);
            groupBox1.Controls.Add(posX);
            groupBox1.Controls.Add(exportButton);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(backMeshMode);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(frontMeshMode);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(exportBrowseBtn);
            groupBox1.Controls.Add(exportPathTextInput);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(objBrowseBtn);
            groupBox1.Controls.Add(objPathTextInput);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 11);
            groupBox1.Margin = new Padding(4, 2, 4, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 2, 4, 2);
            groupBox1.Size = new Size(346, 271);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "File Settings";
            // 
            // bgBtn
            // 
            bgBtn.BackColor = Color.Black;
            bgBtn.FlatAppearance.BorderColor = Color.Gray;
            bgBtn.FlatStyle = FlatStyle.Flat;
            bgBtn.Location = new Point(88, 141);
            bgBtn.Margin = new Padding(4, 2, 4, 2);
            bgBtn.Name = "bgBtn";
            bgBtn.Size = new Size(31, 28);
            bgBtn.TabIndex = 33;
            bgBtn.UseVisualStyleBackColor = false;
            bgBtn.Click += BgBtn_Click;
            // 
            // alphaBtn
            // 
            alphaBtn.BackColor = Color.Black;
            alphaBtn.FlatAppearance.BorderColor = Color.Gray;
            alphaBtn.FlatStyle = FlatStyle.Flat;
            alphaBtn.Location = new Point(267, 141);
            alphaBtn.Margin = new Padding(4, 2, 4, 2);
            alphaBtn.Name = "alphaBtn";
            alphaBtn.Size = new Size(31, 28);
            alphaBtn.TabIndex = 32;
            alphaBtn.UseVisualStyleBackColor = false;
            alphaBtn.Click += OnAlphaColorBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(186, 150);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 31;
            label10.Text = "Alpha:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(6, 150);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(111, 20);
            label9.TabIndex = 30;
            label9.Text = "Background:";
            // 
            // zoomLevel
            // 
            zoomLevel.BackColor = Color.Silver;
            zoomLevel.DecimalPlaces = 1;
            zoomLevel.Location = new Point(270, 75);
            zoomLevel.Margin = new Padding(4, 2, 4, 2);
            zoomLevel.Name = "zoomLevel";
            zoomLevel.RightToLeft = RightToLeft.No;
            zoomLevel.Size = new Size(71, 27);
            zoomLevel.TabIndex = 29;
            zoomLevel.TextAlign = HorizontalAlignment.Center;
            zoomLevel.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(192, 76);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 28;
            label8.Text = "Zoom Level:";
            // 
            // rotZ
            // 
            rotZ.BackColor = Color.Silver;
            rotZ.DecimalPlaces = 1;
            rotZ.Location = new Point(293, 202);
            rotZ.Margin = new Padding(4, 2, 4, 2);
            rotZ.Name = "rotZ";
            rotZ.Size = new Size(48, 27);
            rotZ.TabIndex = 27;
            rotZ.TextAlign = HorizontalAlignment.Center;
            // 
            // rotY
            // 
            rotY.BackColor = Color.Silver;
            rotY.DecimalPlaces = 1;
            rotY.Location = new Point(239, 202);
            rotY.Margin = new Padding(4, 2, 4, 2);
            rotY.Name = "rotY";
            rotY.Size = new Size(48, 27);
            rotY.TabIndex = 26;
            rotY.TextAlign = HorizontalAlignment.Center;
            // 
            // rotX
            // 
            rotX.BackColor = Color.Silver;
            rotX.DecimalPlaces = 1;
            rotX.Location = new Point(186, 202);
            rotX.Margin = new Padding(4, 2, 4, 2);
            rotX.Name = "rotX";
            rotX.Size = new Size(48, 27);
            rotX.TabIndex = 25;
            rotX.TextAlign = HorizontalAlignment.Center;
            // 
            // sizeInput
            // 
            sizeInput.BackColor = Color.Silver;
            sizeInput.DecimalPlaces = 1;
            sizeInput.Location = new Point(88, 72);
            sizeInput.Margin = new Padding(4, 2, 4, 2);
            sizeInput.Name = "sizeInput";
            sizeInput.RightToLeft = RightToLeft.No;
            sizeInput.Size = new Size(71, 27);
            sizeInput.TabIndex = 24;
            sizeInput.TextAlign = HorizontalAlignment.Center;
            sizeInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // posZ
            // 
            posZ.BackColor = Color.Silver;
            posZ.DecimalPlaces = 1;
            posZ.Location = new Point(114, 202);
            posZ.Margin = new Padding(4, 2, 4, 2);
            posZ.Name = "posZ";
            posZ.Size = new Size(48, 27);
            posZ.TabIndex = 23;
            posZ.TextAlign = HorizontalAlignment.Center;
            // 
            // posY
            // 
            posY.BackColor = Color.Silver;
            posY.DecimalPlaces = 1;
            posY.Location = new Point(59, 202);
            posY.Margin = new Padding(4, 2, 4, 2);
            posY.Name = "posY";
            posY.Size = new Size(48, 27);
            posY.TabIndex = 22;
            posY.TextAlign = HorizontalAlignment.Center;
            // 
            // posX
            // 
            posX.BackColor = Color.Silver;
            posX.DecimalPlaces = 1;
            posX.Location = new Point(6, 202);
            posX.Margin = new Padding(4, 2, 4, 2);
            posX.Name = "posX";
            posX.Size = new Size(48, 27);
            posX.TabIndex = 21;
            posX.TextAlign = HorizontalAlignment.Center;
            // 
            // exportButton
            // 
            exportButton.BackColor = Color.FromArgb(64, 65, 79);
            exportButton.FlatAppearance.BorderColor = Color.Black;
            exportButton.FlatStyle = FlatStyle.Flat;
            exportButton.ForeColor = Color.White;
            exportButton.Location = new Point(6, 228);
            exportButton.Margin = new Padding(4, 2, 4, 2);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(335, 32);
            exportButton.TabIndex = 20;
            exportButton.Text = "Convert";
            exportButton.UseVisualStyleBackColor = false;
            exportButton.Click += exportButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(186, 187);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 16;
            label6.Text = "Light Direction:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(6, 187);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 12;
            label5.Text = "Offset:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 110);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 10;
            label4.Text = "Flip Normals:";
            // 
            // backMeshMode
            // 
            backMeshMode.AutoSize = true;
            backMeshMode.Checked = true;
            backMeshMode.FlatStyle = FlatStyle.Flat;
            backMeshMode.Location = new Point(154, 110);
            backMeshMode.Margin = new Padding(4, 2, 4, 2);
            backMeshMode.Name = "backMeshMode";
            backMeshMode.Size = new Size(76, 24);
            backMeshMode.TabIndex = 9;
            backMeshMode.TabStop = true;
            backMeshMode.Text = "False";
            backMeshMode.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 76);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 7;
            label3.Text = "Size:";
            // 
            // frontMeshMode
            // 
            frontMeshMode.AutoSize = true;
            frontMeshMode.FlatStyle = FlatStyle.Flat;
            frontMeshMode.Location = new Point(94, 110);
            frontMeshMode.Margin = new Padding(4, 2, 4, 2);
            frontMeshMode.Name = "frontMeshMode";
            frontMeshMode.Size = new Size(71, 24);
            frontMeshMode.TabIndex = 6;
            frontMeshMode.Text = "True";
            frontMeshMode.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 50);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 5;
            label2.Text = "Export Path:";
            // 
            // exportBrowseBtn
            // 
            exportBrowseBtn.BackColor = Color.FromArgb(64, 65, 79);
            exportBrowseBtn.FlatAppearance.BorderColor = Color.Black;
            exportBrowseBtn.FlatStyle = FlatStyle.Flat;
            exportBrowseBtn.Font = new Font("MS PGothic", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            exportBrowseBtn.Location = new Point(284, 46);
            exportBrowseBtn.Margin = new Padding(4, 2, 4, 2);
            exportBrowseBtn.Name = "exportBrowseBtn";
            exportBrowseBtn.Size = new Size(57, 20);
            exportBrowseBtn.TabIndex = 4;
            exportBrowseBtn.Text = "Browse";
            exportBrowseBtn.UseVisualStyleBackColor = false;
            exportBrowseBtn.Click += exportBrowseBtn_Click;
            // 
            // exportPathTextInput
            // 
            exportPathTextInput.BackColor = Color.Silver;
            exportPathTextInput.Font = new Font("Microsoft Uighur", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            exportPathTextInput.Location = new Point(88, 46);
            exportPathTextInput.Margin = new Padding(4, 2, 4, 2);
            exportPathTextInput.Name = "exportPathTextInput";
            exportPathTextInput.Size = new Size(190, 29);
            exportPathTextInput.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 2;
            label1.Text = "Obj Path:";
            // 
            // objBrowseBtn
            // 
            objBrowseBtn.BackColor = Color.FromArgb(64, 65, 79);
            objBrowseBtn.FlatAppearance.BorderColor = Color.Black;
            objBrowseBtn.FlatStyle = FlatStyle.Flat;
            objBrowseBtn.Font = new Font("MS PGothic", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            objBrowseBtn.Location = new Point(284, 20);
            objBrowseBtn.Margin = new Padding(4, 2, 4, 2);
            objBrowseBtn.Name = "objBrowseBtn";
            objBrowseBtn.Size = new Size(57, 19);
            objBrowseBtn.TabIndex = 1;
            objBrowseBtn.Text = "Browse";
            objBrowseBtn.UseVisualStyleBackColor = false;
            objBrowseBtn.Click += objBrowseBtn_Click;
            // 
            // objPathTextInput
            // 
            objPathTextInput.BackColor = Color.Silver;
            objPathTextInput.Font = new Font("Microsoft Uighur", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            objPathTextInput.Location = new Point(88, 20);
            objPathTextInput.Margin = new Padding(4, 2, 4, 2);
            objPathTextInput.Name = "objPathTextInput";
            objPathTextInput.Size = new Size(190, 29);
            objPathTextInput.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(clearButton);
            groupBox2.Controls.Add(recentListBox);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(365, 11);
            groupBox2.Margin = new Padding(4, 2, 4, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 2, 4, 2);
            groupBox2.Size = new Size(202, 271);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Recent Files";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.White;
            label7.Location = new Point(170, 256);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 28;
            label7.Text = "v0.1";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.FromArgb(64, 65, 79);
            clearButton.FlatAppearance.BorderColor = Color.Black;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(6, 236);
            clearButton.Margin = new Padding(4, 2, 4, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(186, 21);
            clearButton.TabIndex = 6;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // recentListBox
            // 
            recentListBox.BackColor = Color.FromArgb(64, 65, 79);
            recentListBox.ForeColor = Color.Ivory;
            recentListBox.FormattingEnabled = true;
            recentListBox.ItemHeight = 20;
            recentListBox.Items.AddRange(new object[] { "Box.obj", "Sphere.obj", "Box.obj", "Sphere.obj", "Box.obj", "Sphere.obj", "Box.obj", "Sphere.obj", "Box.obj", "Sphere.obj", "Box.obj", "Sphere.obj", "Box.obj", "Sphere.obj", "Box.obj", "Sphere.obj", "Box.obj", "Sphere.obj", "Box.obj", "Sphere.obj" });
            recentListBox.Location = new Point(6, 20);
            recentListBox.Margin = new Padding(4, 2, 4, 2);
            recentListBox.Name = "recentListBox";
            recentListBox.Size = new Size(186, 204);
            recentListBox.TabIndex = 0;
            recentListBox.SelectedIndexChanged += recentListBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 35);
            ClientSize = new Size(572, 275);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("MS PGothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            MaximumSize = new Size(594, 331);
            MinimumSize = new Size(594, 331);
            Name = "Form1";
            Text = "ObjToPicoCAD";
            DragDrop += Form1_DragDrop;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)zoomLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)rotZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)rotY).EndInit();
            ((System.ComponentModel.ISupportInitialize)rotX).EndInit();
            ((System.ComponentModel.ISupportInitialize)sizeInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)posZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)posY).EndInit();
            ((System.ComponentModel.ISupportInitialize)posX).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
		private GroupBox groupBox2;
		private Label label2;
		private Button exportBrowseBtn;
		private TextBox exportPathTextInput;
		private Label label1;
		private Button objBrowseBtn;
		private TextBox objPathTextInput;
		private ListBox recentListBox;
		private Button clearButton;
		private Label label4;
		private RadioButton backMeshMode;
		private Label label3;
		private RadioButton frontMeshMode;
		private Button exportButton;
		private Label label6;
		private Label label5;
		private NumericUpDown posX;
		private NumericUpDown posZ;
		private NumericUpDown posY;
		private NumericUpDown sizeInput;
		private NumericUpDown rotZ;
		private NumericUpDown rotY;
		private NumericUpDown rotX;
		private Label label7;
		private Label label10;
		private Label label9;
		private NumericUpDown zoomLevel;
		private Label label8;
		private Button alphaBtn;
		private Button bgBtn;
	}
}