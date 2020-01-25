namespace _3DModelViewer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.ResetCameraButton = new System.Windows.Forms.Button();
            this.RemoveCameraButton = new System.Windows.Forms.Button();
            this.AddCameraButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CameraListBox = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FOVLabel = new System.Windows.Forms.Label();
            this.FOVSlider = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ZLabel = new System.Windows.Forms.Label();
            this.ZSlider = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.YLabel = new System.Windows.Forms.Label();
            this.YSlider = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.XLabel = new System.Windows.Forms.Label();
            this.XSlider = new System.Windows.Forms.TrackBar();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FOVSlider)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZSlider)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YSlider)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Canvas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 0;
            // 
            // Canvas
            // 
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(600, 450);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseClick);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            this.Canvas.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseWheel);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.splitContainer2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 450);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel3);
            this.splitContainer2.Size = new System.Drawing.Size(196, 450);
            this.splitContainer2.SplitterDistance = 137;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 137);
            this.panel1.TabIndex = 1;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.splitContainer3);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Location = new System.Drawing.Point(0, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(196, 137);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Cameras";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(3, 16);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.ResetCameraButton);
            this.splitContainer3.Panel1.Controls.Add(this.RemoveCameraButton);
            this.splitContainer3.Panel1.Controls.Add(this.AddCameraButton);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.panel4);
            this.splitContainer3.Size = new System.Drawing.Size(190, 118);
            this.splitContainer3.SplitterDistance = 30;
            this.splitContainer3.TabIndex = 0;
            // 
            // ResetCameraButton
            // 
            this.ResetCameraButton.Location = new System.Drawing.Point(143, 3);
            this.ResetCameraButton.Name = "ResetCameraButton";
            this.ResetCameraButton.Size = new System.Drawing.Size(44, 23);
            this.ResetCameraButton.TabIndex = 2;
            this.ResetCameraButton.Text = "Reset";
            this.ResetCameraButton.UseVisualStyleBackColor = true;
            this.ResetCameraButton.Click += new System.EventHandler(this.ResetCameraButton_Click);
            // 
            // RemoveCameraButton
            // 
            this.RemoveCameraButton.Enabled = false;
            this.RemoveCameraButton.Location = new System.Drawing.Point(58, 3);
            this.RemoveCameraButton.Name = "RemoveCameraButton";
            this.RemoveCameraButton.Size = new System.Drawing.Size(60, 23);
            this.RemoveCameraButton.TabIndex = 1;
            this.RemoveCameraButton.Text = "Remove";
            this.RemoveCameraButton.UseVisualStyleBackColor = true;
            this.RemoveCameraButton.Click += new System.EventHandler(this.RemoveCameraButton_Click);
            // 
            // AddCameraButton
            // 
            this.AddCameraButton.Location = new System.Drawing.Point(3, 3);
            this.AddCameraButton.Name = "AddCameraButton";
            this.AddCameraButton.Size = new System.Drawing.Size(53, 23);
            this.AddCameraButton.TabIndex = 0;
            this.AddCameraButton.Text = "Add";
            this.AddCameraButton.UseVisualStyleBackColor = true;
            this.AddCameraButton.Click += new System.EventHandler(this.AddCameraButton_Click);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.CameraListBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.MinimumSize = new System.Drawing.Size(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 82);
            this.panel4.TabIndex = 0;
            // 
            // CameraListBox
            // 
            this.CameraListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CameraListBox.FormattingEnabled = true;
            this.CameraListBox.Location = new System.Drawing.Point(0, 0);
            this.CameraListBox.Name = "CameraListBox";
            this.CameraListBox.Size = new System.Drawing.Size(190, 82);
            this.CameraListBox.TabIndex = 0;
            this.CameraListBox.SelectedIndexChanged += new System.EventHandler(this.CameraListBox_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 309);
            this.panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FOVLabel);
            this.groupBox1.Controls.Add(this.FOVSlider);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 60);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FOV";
            // 
            // FOVLabel
            // 
            this.FOVLabel.AutoSize = true;
            this.FOVLabel.Location = new System.Drawing.Point(152, 28);
            this.FOVLabel.Name = "FOVLabel";
            this.FOVLabel.Size = new System.Drawing.Size(19, 13);
            this.FOVLabel.TabIndex = 1;
            this.FOVLabel.Text = "60";
            // 
            // FOVSlider
            // 
            this.FOVSlider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FOVSlider.AutoSize = false;
            this.FOVSlider.Location = new System.Drawing.Point(12, 16);
            this.FOVSlider.Maximum = 120;
            this.FOVSlider.Minimum = 30;
            this.FOVSlider.Name = "FOVSlider";
            this.FOVSlider.Size = new System.Drawing.Size(138, 40);
            this.FOVSlider.TabIndex = 0;
            this.FOVSlider.TickFrequency = 5;
            this.FOVSlider.Value = 90;
            this.FOVSlider.ValueChanged += new System.EventHandler(this.FOVSlider_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ZLabel);
            this.groupBox2.Controls.Add(this.ZSlider);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 69);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera Z";
            // 
            // ZLabel
            // 
            this.ZLabel.AutoSize = true;
            this.ZLabel.Location = new System.Drawing.Point(170, 24);
            this.ZLabel.Name = "ZLabel";
            this.ZLabel.Size = new System.Drawing.Size(16, 13);
            this.ZLabel.TabIndex = 3;
            this.ZLabel.Text = "-5";
            // 
            // ZSlider
            // 
            this.ZSlider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ZSlider.AutoSize = false;
            this.ZSlider.Location = new System.Drawing.Point(10, 14);
            this.ZSlider.Maximum = 100;
            this.ZSlider.Minimum = 1;
            this.ZSlider.Name = "ZSlider";
            this.ZSlider.Size = new System.Drawing.Size(162, 40);
            this.ZSlider.TabIndex = 2;
            this.ZSlider.TickFrequency = 5;
            this.ZSlider.Value = 2;
            this.ZSlider.ValueChanged += new System.EventHandler(this.ZSlider_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.YLabel);
            this.groupBox4.Controls.Add(this.YSlider);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(196, 67);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Camera Y";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(172, 23);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(13, 13);
            this.YLabel.TabIndex = 5;
            this.YLabel.Text = "0";
            // 
            // YSlider
            // 
            this.YSlider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.YSlider.AutoSize = false;
            this.YSlider.LargeChange = 1;
            this.YSlider.Location = new System.Drawing.Point(11, 13);
            this.YSlider.Maximum = 100;
            this.YSlider.Minimum = -100;
            this.YSlider.Name = "YSlider";
            this.YSlider.Size = new System.Drawing.Size(162, 40);
            this.YSlider.TabIndex = 4;
            this.YSlider.TickFrequency = 5;
            this.YSlider.ValueChanged += new System.EventHandler(this.YSlider_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.XLabel);
            this.groupBox3.Controls.Add(this.XSlider);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 67);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camera X";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(172, 23);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(13, 13);
            this.XLabel.TabIndex = 5;
            this.XLabel.Text = "0";
            // 
            // XSlider
            // 
            this.XSlider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.XSlider.AutoSize = false;
            this.XSlider.LargeChange = 1;
            this.XSlider.Location = new System.Drawing.Point(11, 13);
            this.XSlider.Maximum = 100;
            this.XSlider.Minimum = -100;
            this.XSlider.Name = "XSlider";
            this.XSlider.Size = new System.Drawing.Size(162, 40);
            this.XSlider.TabIndex = 4;
            this.XSlider.TickFrequency = 5;
            this.XSlider.ValueChanged += new System.EventHandler(this.XSlider_ValueChanged);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(_3DModelViewer.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FOVSlider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZSlider)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YSlider)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button RemoveCameraButton;
        private System.Windows.Forms.Button AddCameraButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox CameraListBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label FOVLabel;
        private System.Windows.Forms.TrackBar FOVSlider;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ZLabel;
        private System.Windows.Forms.TrackBar ZSlider;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.TrackBar YSlider;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.TrackBar XSlider;
        private System.Windows.Forms.Button ResetCameraButton;
    }
}

