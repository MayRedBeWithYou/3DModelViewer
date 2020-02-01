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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FPSLabel = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillTrianglesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backfaceCullingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zbufferingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perspectiveCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyrusBeckCullingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.ResetCameraButton = new System.Windows.Forms.Button();
            this.RemoveCameraButton = new System.Windows.Forms.Button();
            this.AddCameraButton = new System.Windows.Forms.Button();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CameraF = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.CameraN = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.FOVLabel = new System.Windows.Forms.Label();
            this.FOVSlider = new System.Windows.Forms.TrackBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CameraListBox = new System.Windows.Forms.ListBox();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.RemoveLightButton = new System.Windows.Forms.Button();
            this.AddLightButton = new System.Windows.Forms.Button();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.LightGroupBox = new System.Windows.Forms.GroupBox();
            this.label70 = new System.Windows.Forms.Label();
            this.LightPosZ = new System.Windows.Forms.NumericUpDown();
            this.label71 = new System.Windows.Forms.Label();
            this.LightPosY = new System.Windows.Forms.NumericUpDown();
            this.label72 = new System.Windows.Forms.Label();
            this.LightPosX = new System.Windows.Forms.NumericUpDown();
            this.label73 = new System.Windows.Forms.Label();
            this.LightRange = new System.Windows.Forms.NumericUpDown();
            this.label69 = new System.Windows.Forms.Label();
            this.LightIntensity = new System.Windows.Forms.NumericUpDown();
            this.label68 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.LightColor = new System.Windows.Forms.PictureBox();
            this.LightListBox = new System.Windows.Forms.ListBox();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.RemoveFigureButton = new System.Windows.Forms.Button();
            this.AddFigureButton = new System.Windows.Forms.Button();
            this.FigureDataGrid = new System.Windows.Forms.DataGridView();
            this.Visibility = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.displayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iFigureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConeGroupBox = new System.Windows.Forms.GroupBox();
            this.label66 = new System.Windows.Forms.Label();
            this.ConeColor = new System.Windows.Forms.PictureBox();
            this.label47 = new System.Windows.Forms.Label();
            this.ConeRadius = new System.Windows.Forms.NumericUpDown();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.ConeHeight = new System.Windows.Forms.NumericUpDown();
            this.ConeDiv = new System.Windows.Forms.NumericUpDown();
            this.label51 = new System.Windows.Forms.Label();
            this.ConeRotZ = new System.Windows.Forms.NumericUpDown();
            this.label52 = new System.Windows.Forms.Label();
            this.ConeRotY = new System.Windows.Forms.NumericUpDown();
            this.label53 = new System.Windows.Forms.Label();
            this.ConeRotX = new System.Windows.Forms.NumericUpDown();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.ConeDimZ = new System.Windows.Forms.NumericUpDown();
            this.label56 = new System.Windows.Forms.Label();
            this.ConeDimY = new System.Windows.Forms.NumericUpDown();
            this.label57 = new System.Windows.Forms.Label();
            this.ConeDimX = new System.Windows.Forms.NumericUpDown();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.ConePosZ = new System.Windows.Forms.NumericUpDown();
            this.label60 = new System.Windows.Forms.Label();
            this.ConePosY = new System.Windows.Forms.NumericUpDown();
            this.label61 = new System.Windows.Forms.Label();
            this.ConePosX = new System.Windows.Forms.NumericUpDown();
            this.label62 = new System.Windows.Forms.Label();
            this.CylinderGroupBox = new System.Windows.Forms.GroupBox();
            this.label63 = new System.Windows.Forms.Label();
            this.CylinderColor = new System.Windows.Forms.PictureBox();
            this.label31 = new System.Windows.Forms.Label();
            this.CylinderRadius = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.CylinderHeight = new System.Windows.Forms.NumericUpDown();
            this.CylinderDiv = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.CylinderRotZ = new System.Windows.Forms.NumericUpDown();
            this.label36 = new System.Windows.Forms.Label();
            this.CylinderRotY = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.CylinderRotX = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.CylinderDimZ = new System.Windows.Forms.NumericUpDown();
            this.label40 = new System.Windows.Forms.Label();
            this.CylinderDimY = new System.Windows.Forms.NumericUpDown();
            this.label41 = new System.Windows.Forms.Label();
            this.CylinderDimX = new System.Windows.Forms.NumericUpDown();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.CylinderPosZ = new System.Windows.Forms.NumericUpDown();
            this.label44 = new System.Windows.Forms.Label();
            this.CylinderPosY = new System.Windows.Forms.NumericUpDown();
            this.label45 = new System.Windows.Forms.Label();
            this.CylinderPosX = new System.Windows.Forms.NumericUpDown();
            this.label46 = new System.Windows.Forms.Label();
            this.CuboidGroupBox = new System.Windows.Forms.GroupBox();
            this.label65 = new System.Windows.Forms.Label();
            this.CuboidColor = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CuboidRotZ = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.CuboidRotY = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.CuboidRotX = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CuboidDimZ = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.CuboidDimY = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.CuboidDimX = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CuboidPosZ = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.CuboidPosY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.CuboidPosX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.SphereGroupBox = new System.Windows.Forms.GroupBox();
            this.label64 = new System.Windows.Forms.Label();
            this.SphereColor = new System.Windows.Forms.PictureBox();
            this.label28 = new System.Windows.Forms.Label();
            this.SphereRadius = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.SphereLon = new System.Windows.Forms.NumericUpDown();
            this.SphereLat = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.SphereRotZ = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.SphereRotY = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.SphereRotX = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SphereDimZ = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.SphereDimY = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.SphereDimX = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SpherePosZ = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.SpherePosY = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.SpherePosX = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.AddFigureMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cuboidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sphereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cylinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FOVSlider)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            this.LightGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LightPosZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FigureDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iFigureBindingSource)).BeginInit();
            this.ConeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConeRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConeHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConeDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConeRotZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConeRotY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConeRotX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConeDimZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConeDimY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConeDimX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConePosZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConePosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConePosX)).BeginInit();
            this.CylinderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderRotZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderRotY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderRotX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderDimZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderDimY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderDimX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderPosZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderPosX)).BeginInit();
            this.CuboidGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CuboidColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboidRotZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboidRotY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboidRotX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboidDimZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboidDimY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboidDimX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboidPosZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboidPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboidPosX)).BeginInit();
            this.SphereGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SphereColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SphereRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SphereLon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SphereLat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SphereRotZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SphereRotY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SphereRotX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SphereDimZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SphereDimY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SphereDimX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpherePosZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpherePosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpherePosX)).BeginInit();
            this.AddFigureMenu.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.Canvas);
            this.splitContainer1.Panel1MinSize = 396;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2MinSize = 200;
            this.splitContainer1.Size = new System.Drawing.Size(974, 697);
            this.splitContainer1.SplitterDistance = 750;
            this.splitContainer1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FPSLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 675);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(750, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FPSLabel
            // 
            this.FPSLabel.Name = "FPSLabel";
            this.FPSLabel.Size = new System.Drawing.Size(47, 20);
            this.FPSLabel.Text = "120 FPS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSceneToolStripMenuItem,
            this.loadSceneToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveSceneToolStripMenuItem
            // 
            this.saveSceneToolStripMenuItem.Name = "saveSceneToolStripMenuItem";
            this.saveSceneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveSceneToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.saveSceneToolStripMenuItem.Text = "Save scene...";
            this.saveSceneToolStripMenuItem.Click += new System.EventHandler(this.saveSceneToolStripMenuItem_Click);
            // 
            // loadSceneToolStripMenuItem
            // 
            this.loadSceneToolStripMenuItem.Name = "loadSceneToolStripMenuItem";
            this.loadSceneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadSceneToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.loadSceneToolStripMenuItem.Text = "Load scene...";
            this.loadSceneToolStripMenuItem.Click += new System.EventHandler(this.loadSceneToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillTrianglesToolStripMenuItem,
            this.backfaceCullingToolStripMenuItem,
            this.zbufferingToolStripMenuItem,
            this.perspectiveCorrectionToolStripMenuItem,
            this.cyrusBeckCullingToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // fillTrianglesToolStripMenuItem
            // 
            this.fillTrianglesToolStripMenuItem.Checked = true;
            this.fillTrianglesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fillTrianglesToolStripMenuItem.Name = "fillTrianglesToolStripMenuItem";
            this.fillTrianglesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.fillTrianglesToolStripMenuItem.Text = "Fill triangles";
            this.fillTrianglesToolStripMenuItem.Click += new System.EventHandler(this.fillTrianglesToolStripMenuItem_Click);
            // 
            // backfaceCullingToolStripMenuItem
            // 
            this.backfaceCullingToolStripMenuItem.Checked = true;
            this.backfaceCullingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backfaceCullingToolStripMenuItem.Name = "backfaceCullingToolStripMenuItem";
            this.backfaceCullingToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.backfaceCullingToolStripMenuItem.Text = "Backface culling";
            this.backfaceCullingToolStripMenuItem.Click += new System.EventHandler(this.backfaceCullingToolStripMenuItem_Click);
            // 
            // zbufferingToolStripMenuItem
            // 
            this.zbufferingToolStripMenuItem.Checked = true;
            this.zbufferingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zbufferingToolStripMenuItem.Name = "zbufferingToolStripMenuItem";
            this.zbufferingToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.zbufferingToolStripMenuItem.Text = "Z-buffering";
            this.zbufferingToolStripMenuItem.Click += new System.EventHandler(this.zbufferingToolStripMenuItem_Click);
            // 
            // perspectiveCorrectionToolStripMenuItem
            // 
            this.perspectiveCorrectionToolStripMenuItem.Enabled = false;
            this.perspectiveCorrectionToolStripMenuItem.Name = "perspectiveCorrectionToolStripMenuItem";
            this.perspectiveCorrectionToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.perspectiveCorrectionToolStripMenuItem.Text = "Perspective correction";
            // 
            // cyrusBeckCullingToolStripMenuItem
            // 
            this.cyrusBeckCullingToolStripMenuItem.Enabled = false;
            this.cyrusBeckCullingToolStripMenuItem.Name = "cyrusBeckCullingToolStripMenuItem";
            this.cyrusBeckCullingToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cyrusBeckCullingToolStripMenuItem.Text = "Cyrus-Beck culling";
            // 
            // Canvas
            // 
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(750, 697);
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
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.splitContainer2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 930);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            this.splitContainer2.Panel1MinSize = 158;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer2.Size = new System.Drawing.Size(203, 930);
            this.splitContainer2.SplitterDistance = 200;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 200);
            this.panel1.TabIndex = 1;
            // 
            // groupBox8
            // 
            this.groupBox8.AutoSize = true;
            this.groupBox8.Controls.Add(this.splitContainer3);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(0, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(203, 200);
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
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(197, 181);
            this.splitContainer3.SplitterDistance = 30;
            this.splitContainer3.TabIndex = 0;
            // 
            // ResetCameraButton
            // 
            this.ResetCameraButton.Location = new System.Drawing.Point(148, 3);
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
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.panel4);
            this.splitContainer4.Size = new System.Drawing.Size(197, 147);
            this.splitContainer4.SplitterDistance = 70;
            this.splitContainer4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CameraF);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.CameraN);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.FOVLabel);
            this.groupBox1.Controls.Add(this.FOVSlider);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 70);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FOV";
            // 
            // CameraF
            // 
            this.CameraF.DecimalPlaces = 2;
            this.CameraF.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.CameraF.Location = new System.Drawing.Point(115, 42);
            this.CameraF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.CameraF.Name = "CameraF";
            this.CameraF.Size = new System.Drawing.Size(47, 20);
            this.CameraF.TabIndex = 5;
            this.CameraF.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CameraF.ValueChanged += new System.EventHandler(this.CameraF_ValueChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(99, 44);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(10, 13);
            this.label30.TabIndex = 4;
            this.label30.Text = "f";
            // 
            // CameraN
            // 
            this.CameraN.DecimalPlaces = 2;
            this.CameraN.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.CameraN.Location = new System.Drawing.Point(27, 42);
            this.CameraN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.CameraN.Name = "CameraN";
            this.CameraN.Size = new System.Drawing.Size(47, 20);
            this.CameraN.TabIndex = 3;
            this.CameraN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CameraN.ValueChanged += new System.EventHandler(this.CameraN_ValueChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(11, 44);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(13, 13);
            this.label29.TabIndex = 2;
            this.label29.Text = "n";
            // 
            // FOVLabel
            // 
            this.FOVLabel.AutoSize = true;
            this.FOVLabel.Location = new System.Drawing.Point(149, 13);
            this.FOVLabel.Name = "FOVLabel";
            this.FOVLabel.Size = new System.Drawing.Size(19, 13);
            this.FOVLabel.TabIndex = 1;
            this.FOVLabel.Text = "60";
            // 
            // FOVSlider
            // 
            this.FOVSlider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FOVSlider.AutoSize = false;
            this.FOVSlider.Location = new System.Drawing.Point(12, 12);
            this.FOVSlider.Maximum = 120;
            this.FOVSlider.Minimum = 30;
            this.FOVSlider.Name = "FOVSlider";
            this.FOVSlider.Size = new System.Drawing.Size(138, 34);
            this.FOVSlider.TabIndex = 0;
            this.FOVSlider.TickFrequency = 5;
            this.FOVSlider.Value = 60;
            this.FOVSlider.ValueChanged += new System.EventHandler(this.FOVSlider_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.CameraListBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.MinimumSize = new System.Drawing.Size(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 73);
            this.panel4.TabIndex = 1;
            // 
            // CameraListBox
            // 
            this.CameraListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CameraListBox.FormattingEnabled = true;
            this.CameraListBox.Location = new System.Drawing.Point(0, 0);
            this.CameraListBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.CameraListBox.Name = "CameraListBox";
            this.CameraListBox.Size = new System.Drawing.Size(197, 73);
            this.CameraListBox.TabIndex = 0;
            this.CameraListBox.SelectedIndexChanged += new System.EventHandler(this.CameraListBox_SelectedIndexChanged);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer5.Size = new System.Drawing.Size(203, 726);
            this.splitContainer5.SplitterDistance = 220;
            this.splitContainer5.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.splitContainer8);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 220);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lights";
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer8.IsSplitterFixed = true;
            this.splitContainer8.Location = new System.Drawing.Point(3, 16);
            this.splitContainer8.Name = "splitContainer8";
            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.RemoveLightButton);
            this.splitContainer8.Panel1.Controls.Add(this.AddLightButton);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.splitContainer9);
            this.splitContainer8.Size = new System.Drawing.Size(197, 201);
            this.splitContainer8.SplitterDistance = 30;
            this.splitContainer8.TabIndex = 1;
            // 
            // RemoveLightButton
            // 
            this.RemoveLightButton.Location = new System.Drawing.Point(58, 3);
            this.RemoveLightButton.Name = "RemoveLightButton";
            this.RemoveLightButton.Size = new System.Drawing.Size(60, 23);
            this.RemoveLightButton.TabIndex = 4;
            this.RemoveLightButton.Text = "Remove";
            this.RemoveLightButton.UseVisualStyleBackColor = true;
            this.RemoveLightButton.Click += new System.EventHandler(this.RemoveLightButton_Click);
            // 
            // AddLightButton
            // 
            this.AddLightButton.Location = new System.Drawing.Point(3, 3);
            this.AddLightButton.Name = "AddLightButton";
            this.AddLightButton.Size = new System.Drawing.Size(53, 23);
            this.AddLightButton.TabIndex = 3;
            this.AddLightButton.Text = "Add";
            this.AddLightButton.UseVisualStyleBackColor = true;
            this.AddLightButton.Click += new System.EventHandler(this.AddLightButton_Click);
            // 
            // splitContainer9
            // 
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer9.IsSplitterFixed = true;
            this.splitContainer9.Location = new System.Drawing.Point(0, 0);
            this.splitContainer9.Name = "splitContainer9";
            this.splitContainer9.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.Controls.Add(this.LightGroupBox);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.LightListBox);
            this.splitContainer9.Size = new System.Drawing.Size(197, 167);
            this.splitContainer9.SplitterDistance = 110;
            this.splitContainer9.TabIndex = 0;
            // 
            // LightGroupBox
            // 
            this.LightGroupBox.Controls.Add(this.label70);
            this.LightGroupBox.Controls.Add(this.LightPosZ);
            this.LightGroupBox.Controls.Add(this.label71);
            this.LightGroupBox.Controls.Add(this.LightPosY);
            this.LightGroupBox.Controls.Add(this.label72);
            this.LightGroupBox.Controls.Add(this.LightPosX);
            this.LightGroupBox.Controls.Add(this.label73);
            this.LightGroupBox.Controls.Add(this.LightRange);
            this.LightGroupBox.Controls.Add(this.label69);
            this.LightGroupBox.Controls.Add(this.LightIntensity);
            this.LightGroupBox.Controls.Add(this.label68);
            this.LightGroupBox.Controls.Add(this.label67);
            this.LightGroupBox.Controls.Add(this.LightColor);
            this.LightGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LightGroupBox.Location = new System.Drawing.Point(0, 0);
            this.LightGroupBox.Name = "LightGroupBox";
            this.LightGroupBox.Size = new System.Drawing.Size(197, 110);
            this.LightGroupBox.TabIndex = 14;
            this.LightGroupBox.TabStop = false;
            this.LightGroupBox.Text = "Light properties";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(121, 85);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(14, 13);
            this.label70.TabIndex = 65;
            this.label70.Text = "Z";
            // 
            // LightPosZ
            // 
            this.LightPosZ.DecimalPlaces = 2;
            this.LightPosZ.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.LightPosZ.Location = new System.Drawing.Point(141, 83);
            this.LightPosZ.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.LightPosZ.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.LightPosZ.Name = "LightPosZ";
            this.LightPosZ.Size = new System.Drawing.Size(53, 20);
            this.LightPosZ.TabIndex = 64;
            this.LightPosZ.ValueChanged += new System.EventHandler(this.LightPosZ_ValueChanged);
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(121, 58);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(14, 13);
            this.label71.TabIndex = 63;
            this.label71.Text = "Y";
            // 
            // LightPosY
            // 
            this.LightPosY.DecimalPlaces = 2;
            this.LightPosY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.LightPosY.Location = new System.Drawing.Point(141, 56);
            this.LightPosY.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.LightPosY.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.LightPosY.Name = "LightPosY";
            this.LightPosY.Size = new System.Drawing.Size(53, 20);
            this.LightPosY.TabIndex = 62;
            this.LightPosY.ValueChanged += new System.EventHandler(this.LightPosY_ValueChanged);
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(121, 32);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(14, 13);
            this.label72.TabIndex = 61;
            this.label72.Text = "X";
            // 
            // LightPosX
            // 
            this.LightPosX.DecimalPlaces = 2;
            this.LightPosX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.LightPosX.Location = new System.Drawing.Point(141, 30);
            this.LightPosX.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.LightPosX.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.LightPosX.Name = "LightPosX";
            this.LightPosX.Size = new System.Drawing.Size(53, 20);
            this.LightPosX.TabIndex = 60;
            this.LightPosX.ValueChanged += new System.EventHandler(this.LightPosX_ValueChanged);
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(120, 13);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(44, 13);
            this.label73.TabIndex = 59;
            this.label73.Text = "Position";
            // 
            // LightRange
            // 
            this.LightRange.DecimalPlaces = 2;
            this.LightRange.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.LightRange.Location = new System.Drawing.Point(61, 82);
            this.LightRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LightRange.Name = "LightRange";
            this.LightRange.Size = new System.Drawing.Size(47, 20);
            this.LightRange.TabIndex = 58;
            this.LightRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LightRange.ValueChanged += new System.EventHandler(this.LightRange_ValueChanged);
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(16, 84);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(39, 13);
            this.label69.TabIndex = 57;
            this.label69.Text = "Range";
            // 
            // LightIntensity
            // 
            this.LightIntensity.DecimalPlaces = 2;
            this.LightIntensity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.LightIntensity.Location = new System.Drawing.Point(61, 56);
            this.LightIntensity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LightIntensity.Name = "LightIntensity";
            this.LightIntensity.Size = new System.Drawing.Size(47, 20);
            this.LightIntensity.TabIndex = 56;
            this.LightIntensity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LightIntensity.ValueChanged += new System.EventHandler(this.LightIntensity_ValueChanged);
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(12, 58);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(46, 13);
            this.label68.TabIndex = 55;
            this.label68.Text = "Intensity";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(27, 34);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(31, 13);
            this.label67.TabIndex = 54;
            this.label67.Text = "Color";
            // 
            // LightColor
            // 
            this.LightColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LightColor.Location = new System.Drawing.Point(62, 31);
            this.LightColor.Name = "LightColor";
            this.LightColor.Size = new System.Drawing.Size(20, 19);
            this.LightColor.TabIndex = 53;
            this.LightColor.TabStop = false;
            this.LightColor.Click += new System.EventHandler(this.LightColor_Click);
            // 
            // LightListBox
            // 
            this.LightListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LightListBox.FormattingEnabled = true;
            this.LightListBox.Location = new System.Drawing.Point(0, 0);
            this.LightListBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.LightListBox.Name = "LightListBox";
            this.LightListBox.Size = new System.Drawing.Size(197, 53);
            this.LightListBox.TabIndex = 1;
            this.LightListBox.SelectedIndexChanged += new System.EventHandler(this.LightListBox_SelectedIndexChanged);
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer6.IsSplitterFixed = true;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer6.Panel1MinSize = 170;
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.AutoScroll = true;
            this.splitContainer6.Panel2.Controls.Add(this.ConeGroupBox);
            this.splitContainer6.Panel2.Controls.Add(this.CylinderGroupBox);
            this.splitContainer6.Panel2.Controls.Add(this.CuboidGroupBox);
            this.splitContainer6.Panel2.Controls.Add(this.SphereGroupBox);
            this.splitContainer6.Size = new System.Drawing.Size(203, 502);
            this.splitContainer6.SplitterDistance = 200;
            this.splitContainer6.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 200);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Figures";
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer7.IsSplitterFixed = true;
            this.splitContainer7.Location = new System.Drawing.Point(3, 16);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.RemoveFigureButton);
            this.splitContainer7.Panel1.Controls.Add(this.AddFigureButton);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.FigureDataGrid);
            this.splitContainer7.Size = new System.Drawing.Size(197, 181);
            this.splitContainer7.SplitterDistance = 30;
            this.splitContainer7.TabIndex = 0;
            // 
            // RemoveFigureButton
            // 
            this.RemoveFigureButton.Location = new System.Drawing.Point(102, 4);
            this.RemoveFigureButton.Name = "RemoveFigureButton";
            this.RemoveFigureButton.Size = new System.Drawing.Size(89, 23);
            this.RemoveFigureButton.TabIndex = 1;
            this.RemoveFigureButton.Text = "Remove figure";
            this.RemoveFigureButton.UseVisualStyleBackColor = true;
            this.RemoveFigureButton.Click += new System.EventHandler(this.RemoveFigureButton_Click);
            // 
            // AddFigureButton
            // 
            this.AddFigureButton.Location = new System.Drawing.Point(3, 4);
            this.AddFigureButton.Name = "AddFigureButton";
            this.AddFigureButton.Size = new System.Drawing.Size(75, 23);
            this.AddFigureButton.TabIndex = 0;
            this.AddFigureButton.Text = "Add figure...";
            this.AddFigureButton.UseVisualStyleBackColor = true;
            this.AddFigureButton.Click += new System.EventHandler(this.AddFigureButton_Click);
            // 
            // FigureDataGrid
            // 
            this.FigureDataGrid.AllowUserToAddRows = false;
            this.FigureDataGrid.AllowUserToResizeColumns = false;
            this.FigureDataGrid.AllowUserToResizeRows = false;
            this.FigureDataGrid.AutoGenerateColumns = false;
            this.FigureDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.FigureDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FigureDataGrid.ColumnHeadersVisible = false;
            this.FigureDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Visibility,
            this.displayNameDataGridViewTextBoxColumn});
            this.FigureDataGrid.DataSource = this.iFigureBindingSource;
            this.FigureDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FigureDataGrid.Location = new System.Drawing.Point(0, 0);
            this.FigureDataGrid.MultiSelect = false;
            this.FigureDataGrid.Name = "FigureDataGrid";
            this.FigureDataGrid.RowHeadersVisible = false;
            this.FigureDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.FigureDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FigureDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FigureDataGrid.Size = new System.Drawing.Size(197, 147);
            this.FigureDataGrid.TabIndex = 1;
            this.FigureDataGrid.SelectionChanged += new System.EventHandler(this.FigureDataGrid_SelectionChanged);
            // 
            // Visibility
            // 
            this.Visibility.DataPropertyName = "Visibility";
            this.Visibility.FalseValue = "false";
            this.Visibility.HeaderText = "Visibility";
            this.Visibility.Name = "Visibility";
            this.Visibility.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Visibility.TrueValue = "true";
            this.Visibility.Width = 25;
            // 
            // displayNameDataGridViewTextBoxColumn
            // 
            this.displayNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.displayNameDataGridViewTextBoxColumn.DataPropertyName = "DisplayName";
            this.displayNameDataGridViewTextBoxColumn.HeaderText = "DisplayName";
            this.displayNameDataGridViewTextBoxColumn.Name = "displayNameDataGridViewTextBoxColumn";
            this.displayNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.displayNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // iFigureBindingSource
            // 
            this.iFigureBindingSource.DataSource = typeof(_3DModelViewer.IFigure);
            // 
            // ConeGroupBox
            // 
            this.ConeGroupBox.Controls.Add(this.label66);
            this.ConeGroupBox.Controls.Add(this.ConeColor);
            this.ConeGroupBox.Controls.Add(this.label47);
            this.ConeGroupBox.Controls.Add(this.ConeRadius);
            this.ConeGroupBox.Controls.Add(this.label48);
            this.ConeGroupBox.Controls.Add(this.label49);
            this.ConeGroupBox.Controls.Add(this.label50);
            this.ConeGroupBox.Controls.Add(this.ConeHeight);
            this.ConeGroupBox.Controls.Add(this.ConeDiv);
            this.ConeGroupBox.Controls.Add(this.label51);
            this.ConeGroupBox.Controls.Add(this.ConeRotZ);
            this.ConeGroupBox.Controls.Add(this.label52);
            this.ConeGroupBox.Controls.Add(this.ConeRotY);
            this.ConeGroupBox.Controls.Add(this.label53);
            this.ConeGroupBox.Controls.Add(this.ConeRotX);
            this.ConeGroupBox.Controls.Add(this.label54);
            this.ConeGroupBox.Controls.Add(this.label55);
            this.ConeGroupBox.Controls.Add(this.ConeDimZ);
            this.ConeGroupBox.Controls.Add(this.label56);
            this.ConeGroupBox.Controls.Add(this.ConeDimY);
            this.ConeGroupBox.Controls.Add(this.label57);
            this.ConeGroupBox.Controls.Add(this.ConeDimX);
            this.ConeGroupBox.Controls.Add(this.label58);
            this.ConeGroupBox.Controls.Add(this.label59);
            this.ConeGroupBox.Controls.Add(this.ConePosZ);
            this.ConeGroupBox.Controls.Add(this.label60);
            this.ConeGroupBox.Controls.Add(this.ConePosY);
            this.ConeGroupBox.Controls.Add(this.label61);
            this.ConeGroupBox.Controls.Add(this.ConePosX);
            this.ConeGroupBox.Controls.Add(this.label62);
            this.ConeGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConeGroupBox.Location = new System.Drawing.Point(0, 736);
            this.ConeGroupBox.Name = "ConeGroupBox";
            this.ConeGroupBox.Size = new System.Drawing.Size(186, 246);
            this.ConeGroupBox.TabIndex = 3;
            this.ConeGroupBox.TabStop = false;
            this.ConeGroupBox.Text = "Cone properties";
            this.ConeGroupBox.Visible = false;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(9, 214);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(31, 13);
            this.label66.TabIndex = 56;
            this.label66.Text = "Color";
            // 
            // ConeColor
            // 
            this.ConeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ConeColor.Location = new System.Drawing.Point(44, 211);
            this.ConeColor.Name = "ConeColor";
            this.ConeColor.Size = new System.Drawing.Size(20, 19);
            this.ConeColor.TabIndex = 55;
            this.ConeColor.TabStop = false;
            this.ConeColor.Click += new System.EventHandler(this.ConeColor_Click);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(100, 186);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(15, 13);
            this.label47.TabIndex = 48;
            this.label47.Text = "R";
            // 
            // ConeRadius
            // 
            this.ConeRadius.DecimalPlaces = 2;
            this.ConeRadius.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.ConeRadius.Location = new System.Drawing.Point(121, 184);
            this.ConeRadius.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ConeRadius.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.ConeRadius.Name = "ConeRadius";
            this.ConeRadius.Size = new System.Drawing.Size(53, 20);
            this.ConeRadius.TabIndex = 47;
            this.ConeRadius.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.ConeRadius.ValueChanged += new System.EventHandler(this.ConeRadius_ValueChanged);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(100, 158);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(15, 13);
            this.label48.TabIndex = 46;
            this.label48.Text = "H";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(95, 133);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(23, 13);
            this.label49.TabIndex = 45;
            this.label49.Text = "Div";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(101, 114);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(60, 13);
            this.label50.TabIndex = 44;
            this.label50.Text = "Parameters";
            // 
            // ConeHeight
            // 
            this.ConeHeight.DecimalPlaces = 2;
            this.ConeHeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.ConeHeight.Location = new System.Drawing.Point(121, 156);
            this.ConeHeight.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ConeHeight.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.ConeHeight.Name = "ConeHeight";
            this.ConeHeight.Size = new System.Drawing.Size(53, 20);
            this.ConeHeight.TabIndex = 43;
            this.ConeHeight.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ConeHeight.ValueChanged += new System.EventHandler(this.ConeHeight_ValueChanged);
            // 
            // ConeDiv
            // 
            this.ConeDiv.Location = new System.Drawing.Point(121, 130);
            this.ConeDiv.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ConeDiv.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ConeDiv.Name = "ConeDiv";
            this.ConeDiv.Size = new System.Drawing.Size(53, 20);
            this.ConeDiv.TabIndex = 42;
            this.ConeDiv.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ConeDiv.ValueChanged += new System.EventHandler(this.ConeDiv_ValueChanged);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(9, 185);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(14, 13);
            this.label51.TabIndex = 41;
            this.label51.Text = "Z";
            // 
            // ConeRotZ
            // 
            this.ConeRotZ.DecimalPlaces = 1;
            this.ConeRotZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ConeRotZ.Location = new System.Drawing.Point(29, 183);
            this.ConeRotZ.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.ConeRotZ.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.ConeRotZ.Name = "ConeRotZ";
            this.ConeRotZ.Size = new System.Drawing.Size(53, 20);
            this.ConeRotZ.TabIndex = 40;
            this.ConeRotZ.ValueChanged += new System.EventHandler(this.ConeRotZ_ValueChanged);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(9, 158);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(14, 13);
            this.label52.TabIndex = 39;
            this.label52.Text = "Y";
            // 
            // ConeRotY
            // 
            this.ConeRotY.DecimalPlaces = 1;
            this.ConeRotY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ConeRotY.Location = new System.Drawing.Point(29, 156);
            this.ConeRotY.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.ConeRotY.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.ConeRotY.Name = "ConeRotY";
            this.ConeRotY.Size = new System.Drawing.Size(53, 20);
            this.ConeRotY.TabIndex = 38;
            this.ConeRotY.ValueChanged += new System.EventHandler(this.ConeRotY_ValueChanged);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(9, 132);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(14, 13);
            this.label53.TabIndex = 37;
            this.label53.Text = "X";
            // 
            // ConeRotX
            // 
            this.ConeRotX.DecimalPlaces = 1;
            this.ConeRotX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ConeRotX.Location = new System.Drawing.Point(29, 130);
            this.ConeRotX.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.ConeRotX.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.ConeRotX.Name = "ConeRotX";
            this.ConeRotX.Size = new System.Drawing.Size(53, 20);
            this.ConeRotX.TabIndex = 36;
            this.ConeRotX.ValueChanged += new System.EventHandler(this.ConeRotX_ValueChanged);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(6, 114);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(47, 13);
            this.label54.TabIndex = 35;
            this.label54.Text = "Rotation";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(101, 87);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(14, 13);
            this.label55.TabIndex = 34;
            this.label55.Text = "Z";
            // 
            // ConeDimZ
            // 
            this.ConeDimZ.DecimalPlaces = 2;
            this.ConeDimZ.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.ConeDimZ.Location = new System.Drawing.Point(121, 85);
            this.ConeDimZ.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ConeDimZ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ConeDimZ.Name = "ConeDimZ";
            this.ConeDimZ.Size = new System.Drawing.Size(53, 20);
            this.ConeDimZ.TabIndex = 33;
            this.ConeDimZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ConeDimZ.ValueChanged += new System.EventHandler(this.ConeDimZ_ValueChanged);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(101, 60);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(14, 13);
            this.label56.TabIndex = 32;
            this.label56.Text = "Y";
            // 
            // ConeDimY
            // 
            this.ConeDimY.DecimalPlaces = 2;
            this.ConeDimY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.ConeDimY.Location = new System.Drawing.Point(121, 58);
            this.ConeDimY.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ConeDimY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ConeDimY.Name = "ConeDimY";
            this.ConeDimY.Size = new System.Drawing.Size(53, 20);
            this.ConeDimY.TabIndex = 31;
            this.ConeDimY.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ConeDimY.ValueChanged += new System.EventHandler(this.ConeDimY_ValueChanged);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(101, 34);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(14, 13);
            this.label57.TabIndex = 30;
            this.label57.Text = "X";
            // 
            // ConeDimX
            // 
            this.ConeDimX.DecimalPlaces = 2;
            this.ConeDimX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.ConeDimX.Location = new System.Drawing.Point(121, 32);
            this.ConeDimX.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ConeDimX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ConeDimX.Name = "ConeDimX";
            this.ConeDimX.Size = new System.Drawing.Size(53, 20);
            this.ConeDimX.TabIndex = 29;
            this.ConeDimX.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ConeDimX.ValueChanged += new System.EventHandler(this.ConeDimX_ValueChanged);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(98, 16);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(34, 13);
            this.label58.TabIndex = 28;
            this.label58.Text = "Scale";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(9, 87);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(14, 13);
            this.label59.TabIndex = 27;
            this.label59.Text = "Z";
            // 
            // ConePosZ
            // 
            this.ConePosZ.DecimalPlaces = 2;
            this.ConePosZ.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.ConePosZ.Location = new System.Drawing.Point(29, 85);
            this.ConePosZ.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ConePosZ.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.ConePosZ.Name = "ConePosZ";
            this.ConePosZ.Size = new System.Drawing.Size(53, 20);
            this.ConePosZ.TabIndex = 26;
            this.ConePosZ.ValueChanged += new System.EventHandler(this.ConePosZ_ValueChanged);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(9, 60);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(14, 13);
            this.label60.TabIndex = 25;
            this.label60.Text = "Y";
            // 
            // ConePosY
            // 
            this.ConePosY.DecimalPlaces = 2;
            this.ConePosY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.ConePosY.Location = new System.Drawing.Point(29, 58);
            this.ConePosY.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ConePosY.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.ConePosY.Name = "ConePosY";
            this.ConePosY.Size = new System.Drawing.Size(53, 20);
            this.ConePosY.TabIndex = 24;
            this.ConePosY.ValueChanged += new System.EventHandler(this.ConePosY_ValueChanged);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(9, 34);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(14, 13);
            this.label61.TabIndex = 23;
            this.label61.Text = "X";
            // 
            // ConePosX
            // 
            this.ConePosX.DecimalPlaces = 2;
            this.ConePosX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.ConePosX.Location = new System.Drawing.Point(29, 32);
            this.ConePosX.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ConePosX.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.ConePosX.Name = "ConePosX";
            this.ConePosX.Size = new System.Drawing.Size(53, 20);
            this.ConePosX.TabIndex = 22;
            this.ConePosX.ValueChanged += new System.EventHandler(this.ConePosX_ValueChanged);
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(6, 16);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(44, 13);
            this.label62.TabIndex = 21;
            this.label62.Text = "Position";
            // 
            // CylinderGroupBox
            // 
            this.CylinderGroupBox.Controls.Add(this.label63);
            this.CylinderGroupBox.Controls.Add(this.CylinderColor);
            this.CylinderGroupBox.Controls.Add(this.label31);
            this.CylinderGroupBox.Controls.Add(this.CylinderRadius);
            this.CylinderGroupBox.Controls.Add(this.label32);
            this.CylinderGroupBox.Controls.Add(this.label33);
            this.CylinderGroupBox.Controls.Add(this.label34);
            this.CylinderGroupBox.Controls.Add(this.CylinderHeight);
            this.CylinderGroupBox.Controls.Add(this.CylinderDiv);
            this.CylinderGroupBox.Controls.Add(this.label35);
            this.CylinderGroupBox.Controls.Add(this.CylinderRotZ);
            this.CylinderGroupBox.Controls.Add(this.label36);
            this.CylinderGroupBox.Controls.Add(this.CylinderRotY);
            this.CylinderGroupBox.Controls.Add(this.label37);
            this.CylinderGroupBox.Controls.Add(this.CylinderRotX);
            this.CylinderGroupBox.Controls.Add(this.label38);
            this.CylinderGroupBox.Controls.Add(this.label39);
            this.CylinderGroupBox.Controls.Add(this.CylinderDimZ);
            this.CylinderGroupBox.Controls.Add(this.label40);
            this.CylinderGroupBox.Controls.Add(this.CylinderDimY);
            this.CylinderGroupBox.Controls.Add(this.label41);
            this.CylinderGroupBox.Controls.Add(this.CylinderDimX);
            this.CylinderGroupBox.Controls.Add(this.label42);
            this.CylinderGroupBox.Controls.Add(this.label43);
            this.CylinderGroupBox.Controls.Add(this.CylinderPosZ);
            this.CylinderGroupBox.Controls.Add(this.label44);
            this.CylinderGroupBox.Controls.Add(this.CylinderPosY);
            this.CylinderGroupBox.Controls.Add(this.label45);
            this.CylinderGroupBox.Controls.Add(this.CylinderPosX);
            this.CylinderGroupBox.Controls.Add(this.label46);
            this.CylinderGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CylinderGroupBox.Location = new System.Drawing.Point(0, 490);
            this.CylinderGroupBox.Name = "CylinderGroupBox";
            this.CylinderGroupBox.Size = new System.Drawing.Size(186, 246);
            this.CylinderGroupBox.TabIndex = 2;
            this.CylinderGroupBox.TabStop = false;
            this.CylinderGroupBox.Text = "Cylinder properties";
            this.CylinderGroupBox.Visible = false;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(9, 214);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(31, 13);
            this.label63.TabIndex = 50;
            this.label63.Text = "Color";
            // 
            // CylinderColor
            // 
            this.CylinderColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CylinderColor.Location = new System.Drawing.Point(44, 211);
            this.CylinderColor.Name = "CylinderColor";
            this.CylinderColor.Size = new System.Drawing.Size(20, 19);
            this.CylinderColor.TabIndex = 49;
            this.CylinderColor.TabStop = false;
            this.CylinderColor.Click += new System.EventHandler(this.CylinderColor_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(100, 186);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(15, 13);
            this.label31.TabIndex = 48;
            this.label31.Text = "R";
            // 
            // CylinderRadius
            // 
            this.CylinderRadius.DecimalPlaces = 2;
            this.CylinderRadius.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.CylinderRadius.Location = new System.Drawing.Point(121, 184);
            this.CylinderRadius.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CylinderRadius.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.CylinderRadius.Name = "CylinderRadius";
            this.CylinderRadius.Size = new System.Drawing.Size(53, 20);
            this.CylinderRadius.TabIndex = 47;
            this.CylinderRadius.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.CylinderRadius.ValueChanged += new System.EventHandler(this.CylinderRadius_ValueChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(100, 158);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(15, 13);
            this.label32.TabIndex = 46;
            this.label32.Text = "H";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(95, 133);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(23, 13);
            this.label33.TabIndex = 45;
            this.label33.Text = "Div";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(101, 114);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(60, 13);
            this.label34.TabIndex = 44;
            this.label34.Text = "Parameters";
            // 
            // CylinderHeight
            // 
            this.CylinderHeight.DecimalPlaces = 2;
            this.CylinderHeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.CylinderHeight.Location = new System.Drawing.Point(121, 156);
            this.CylinderHeight.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CylinderHeight.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.CylinderHeight.Name = "CylinderHeight";
            this.CylinderHeight.Size = new System.Drawing.Size(53, 20);
            this.CylinderHeight.TabIndex = 43;
            this.CylinderHeight.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.CylinderHeight.ValueChanged += new System.EventHandler(this.CylinderHeight_ValueChanged);
            // 
            // CylinderDiv
            // 
            this.CylinderDiv.Location = new System.Drawing.Point(121, 130);
            this.CylinderDiv.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CylinderDiv.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.CylinderDiv.Name = "CylinderDiv";
            this.CylinderDiv.Size = new System.Drawing.Size(53, 20);
            this.CylinderDiv.TabIndex = 42;
            this.CylinderDiv.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.CylinderDiv.ValueChanged += new System.EventHandler(this.CylinderDiv_ValueChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(9, 185);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(14, 13);
            this.label35.TabIndex = 41;
            this.label35.Text = "Z";
            // 
            // CylinderRotZ
            // 
            this.CylinderRotZ.DecimalPlaces = 1;
            this.CylinderRotZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CylinderRotZ.Location = new System.Drawing.Point(29, 183);
            this.CylinderRotZ.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.CylinderRotZ.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.CylinderRotZ.Name = "CylinderRotZ";
            this.CylinderRotZ.Size = new System.Drawing.Size(53, 20);
            this.CylinderRotZ.TabIndex = 40;
            this.CylinderRotZ.ValueChanged += new System.EventHandler(this.CylinderRotZ_ValueChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(9, 158);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(14, 13);
            this.label36.TabIndex = 39;
            this.label36.Text = "Y";
            // 
            // CylinderRotY
            // 
            this.CylinderRotY.DecimalPlaces = 1;
            this.CylinderRotY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CylinderRotY.Location = new System.Drawing.Point(29, 156);
            this.CylinderRotY.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.CylinderRotY.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.CylinderRotY.Name = "CylinderRotY";
            this.CylinderRotY.Size = new System.Drawing.Size(53, 20);
            this.CylinderRotY.TabIndex = 38;
            this.CylinderRotY.ValueChanged += new System.EventHandler(this.CylinderRotY_ValueChanged);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(9, 132);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(14, 13);
            this.label37.TabIndex = 37;
            this.label37.Text = "X";
            // 
            // CylinderRotX
            // 
            this.CylinderRotX.DecimalPlaces = 1;
            this.CylinderRotX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CylinderRotX.Location = new System.Drawing.Point(29, 130);
            this.CylinderRotX.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.CylinderRotX.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.CylinderRotX.Name = "CylinderRotX";
            this.CylinderRotX.Size = new System.Drawing.Size(53, 20);
            this.CylinderRotX.TabIndex = 36;
            this.CylinderRotX.ValueChanged += new System.EventHandler(this.CylinderRotX_ValueChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 114);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(47, 13);
            this.label38.TabIndex = 35;
            this.label38.Text = "Rotation";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(101, 87);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(14, 13);
            this.label39.TabIndex = 34;
            this.label39.Text = "Z";
            // 
            // CylinderDimZ
            // 
            this.CylinderDimZ.DecimalPlaces = 2;
            this.CylinderDimZ.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.CylinderDimZ.Location = new System.Drawing.Point(121, 85);
            this.CylinderDimZ.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CylinderDimZ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CylinderDimZ.Name = "CylinderDimZ";
            this.CylinderDimZ.Size = new System.Drawing.Size(53, 20);
            this.CylinderDimZ.TabIndex = 33;
            this.CylinderDimZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CylinderDimZ.ValueChanged += new System.EventHandler(this.CylinderDimZ_ValueChanged);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(101, 60);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(14, 13);
            this.label40.TabIndex = 32;
            this.label40.Text = "Y";
            // 
            // CylinderDimY
            // 
            this.CylinderDimY.DecimalPlaces = 2;
            this.CylinderDimY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.CylinderDimY.Location = new System.Drawing.Point(121, 58);
            this.CylinderDimY.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CylinderDimY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CylinderDimY.Name = "CylinderDimY";
            this.CylinderDimY.Size = new System.Drawing.Size(53, 20);
            this.CylinderDimY.TabIndex = 31;
            this.CylinderDimY.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CylinderDimY.ValueChanged += new System.EventHandler(this.CylinderDimY_ValueChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(101, 34);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(14, 13);
            this.label41.TabIndex = 30;
            this.label41.Text = "X";
            // 
            // CylinderDimX
            // 
            this.CylinderDimX.DecimalPlaces = 2;
            this.CylinderDimX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.CylinderDimX.Location = new System.Drawing.Point(121, 32);
            this.CylinderDimX.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CylinderDimX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CylinderDimX.Name = "CylinderDimX";
            this.CylinderDimX.Size = new System.Drawing.Size(53, 20);
            this.CylinderDimX.TabIndex = 29;
            this.CylinderDimX.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CylinderDimX.ValueChanged += new System.EventHandler(this.CylinderDimX_ValueChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(98, 16);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(34, 13);
            this.label42.TabIndex = 28;
            this.label42.Text = "Scale";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(9, 87);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(14, 13);
            this.label43.TabIndex = 27;
            this.label43.Text = "Z";
            // 
            // CylinderPosZ
            // 
            this.CylinderPosZ.DecimalPlaces = 2;
            this.CylinderPosZ.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.CylinderPosZ.Location = new System.Drawing.Point(29, 85);
            this.CylinderPosZ.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CylinderPosZ.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.CylinderPosZ.Name = "CylinderPosZ";
            this.CylinderPosZ.Size = new System.Drawing.Size(53, 20);
            this.CylinderPosZ.TabIndex = 26;
            this.CylinderPosZ.ValueChanged += new System.EventHandler(this.CylinderPosZ_ValueChanged);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(9, 60);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(14, 13);
            this.label44.TabIndex = 25;
            this.label44.Text = "Y";
            // 
            // CylinderPosY
            // 
            this.CylinderPosY.DecimalPlaces = 2;
            this.CylinderPosY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.CylinderPosY.Location = new System.Drawing.Point(29, 58);
            this.CylinderPosY.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CylinderPosY.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.CylinderPosY.Name = "CylinderPosY";
            this.CylinderPosY.Size = new System.Drawing.Size(53, 20);
            this.CylinderPosY.TabIndex = 24;
            this.CylinderPosY.ValueChanged += new System.EventHandler(this.CylinderPosY_ValueChanged);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(9, 34);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(14, 13);
            this.label45.TabIndex = 23;
            this.label45.Text = "X";
            // 
            // CylinderPosX
            // 
            this.CylinderPosX.DecimalPlaces = 2;
            this.CylinderPosX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.CylinderPosX.Location = new System.Drawing.Point(29, 32);
            this.CylinderPosX.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CylinderPosX.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.CylinderPosX.Name = "CylinderPosX";
            this.CylinderPosX.Size = new System.Drawing.Size(53, 20);
            this.CylinderPosX.TabIndex = 22;
            this.CylinderPosX.ValueChanged += new System.EventHandler(this.CylinderPosX_ValueChanged);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(6, 16);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(44, 13);
            this.label46.TabIndex = 21;
            this.label46.Text = "Position";
            // 
            // CuboidGroupBox
            // 
            this.CuboidGroupBox.Controls.Add(this.label65);
            this.CuboidGroupBox.Controls.Add(this.CuboidColor);
            this.CuboidGroupBox.Controls.Add(this.label9);
            this.CuboidGroupBox.Controls.Add(this.CuboidRotZ);
            this.CuboidGroupBox.Controls.Add(this.label10);
            this.CuboidGroupBox.Controls.Add(this.CuboidRotY);
            this.CuboidGroupBox.Controls.Add(this.label11);
            this.CuboidGroupBox.Controls.Add(this.CuboidRotX);
            this.CuboidGroupBox.Controls.Add(this.label12);
            this.CuboidGroupBox.Controls.Add(this.label5);
            this.CuboidGroupBox.Controls.Add(this.CuboidDimZ);
            this.CuboidGroupBox.Controls.Add(this.label6);
            this.CuboidGroupBox.Controls.Add(this.CuboidDimY);
            this.CuboidGroupBox.Controls.Add(this.label7);
            this.CuboidGroupBox.Controls.Add(this.CuboidDimX);
            this.CuboidGroupBox.Controls.Add(this.label8);
            this.CuboidGroupBox.Controls.Add(this.label4);
            this.CuboidGroupBox.Controls.Add(this.CuboidPosZ);
            this.CuboidGroupBox.Controls.Add(this.label3);
            this.CuboidGroupBox.Controls.Add(this.CuboidPosY);
            this.CuboidGroupBox.Controls.Add(this.label2);
            this.CuboidGroupBox.Controls.Add(this.CuboidPosX);
            this.CuboidGroupBox.Controls.Add(this.label1);
            this.CuboidGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CuboidGroupBox.Location = new System.Drawing.Point(0, 246);
            this.CuboidGroupBox.Name = "CuboidGroupBox";
            this.CuboidGroupBox.Size = new System.Drawing.Size(186, 244);
            this.CuboidGroupBox.TabIndex = 0;
            this.CuboidGroupBox.TabStop = false;
            this.CuboidGroupBox.Text = "Cuboid properties";
            this.CuboidGroupBox.Visible = false;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(9, 213);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(31, 13);
            this.label65.TabIndex = 54;
            this.label65.Text = "Color";
            // 
            // CuboidColor
            // 
            this.CuboidColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CuboidColor.Location = new System.Drawing.Point(44, 210);
            this.CuboidColor.Name = "CuboidColor";
            this.CuboidColor.Size = new System.Drawing.Size(20, 19);
            this.CuboidColor.TabIndex = 53;
            this.CuboidColor.TabStop = false;
            this.CuboidColor.Click += new System.EventHandler(this.CuboidColor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Z";
            // 
            // CuboidRotZ
            // 
            this.CuboidRotZ.DecimalPlaces = 1;
            this.CuboidRotZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CuboidRotZ.Location = new System.Drawing.Point(26, 182);
            this.CuboidRotZ.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.CuboidRotZ.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.CuboidRotZ.Name = "CuboidRotZ";
            this.CuboidRotZ.Size = new System.Drawing.Size(53, 20);
            this.CuboidRotZ.TabIndex = 19;
            this.CuboidRotZ.ValueChanged += new System.EventHandler(this.CuboidRotZ_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Y";
            // 
            // CuboidRotY
            // 
            this.CuboidRotY.DecimalPlaces = 1;
            this.CuboidRotY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CuboidRotY.Location = new System.Drawing.Point(26, 155);
            this.CuboidRotY.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.CuboidRotY.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.CuboidRotY.Name = "CuboidRotY";
            this.CuboidRotY.Size = new System.Drawing.Size(53, 20);
            this.CuboidRotY.TabIndex = 17;
            this.CuboidRotY.ValueChanged += new System.EventHandler(this.CuboidRotY_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "X";
            // 
            // CuboidRotX
            // 
            this.CuboidRotX.DecimalPlaces = 1;
            this.CuboidRotX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CuboidRotX.Location = new System.Drawing.Point(26, 129);
            this.CuboidRotX.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.CuboidRotX.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.CuboidRotX.Name = "CuboidRotX";
            this.CuboidRotX.Size = new System.Drawing.Size(53, 20);
            this.CuboidRotX.TabIndex = 15;
            this.CuboidRotX.ValueChanged += new System.EventHandler(this.CuboidRotX_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Rotation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Z";
            // 
            // CuboidDimZ
            // 
            this.CuboidDimZ.DecimalPlaces = 2;
            this.CuboidDimZ.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.CuboidDimZ.Location = new System.Drawing.Point(118, 85);
            this.CuboidDimZ.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CuboidDimZ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CuboidDimZ.Name = "CuboidDimZ";
            this.CuboidDimZ.Size = new System.Drawing.Size(53, 20);
            this.CuboidDimZ.TabIndex = 12;
            this.CuboidDimZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CuboidDimZ.ValueChanged += new System.EventHandler(this.CuboidDimZ_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Y";
            // 
            // CuboidDimY
            // 
            this.CuboidDimY.DecimalPlaces = 2;
            this.CuboidDimY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.CuboidDimY.Location = new System.Drawing.Point(118, 58);
            this.CuboidDimY.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CuboidDimY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CuboidDimY.Name = "CuboidDimY";
            this.CuboidDimY.Size = new System.Drawing.Size(53, 20);
            this.CuboidDimY.TabIndex = 10;
            this.CuboidDimY.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CuboidDimY.ValueChanged += new System.EventHandler(this.CuboidDimY_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "X";
            // 
            // CuboidDimX
            // 
            this.CuboidDimX.DecimalPlaces = 2;
            this.CuboidDimX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.CuboidDimX.Location = new System.Drawing.Point(118, 32);
            this.CuboidDimX.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CuboidDimX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CuboidDimX.Name = "CuboidDimX";
            this.CuboidDimX.Size = new System.Drawing.Size(53, 20);
            this.CuboidDimX.TabIndex = 8;
            this.CuboidDimX.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CuboidDimX.ValueChanged += new System.EventHandler(this.CuboidDimX_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dimensions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Z";
            // 
            // CuboidPosZ
            // 
            this.CuboidPosZ.DecimalPlaces = 2;
            this.CuboidPosZ.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.CuboidPosZ.Location = new System.Drawing.Point(26, 85);
            this.CuboidPosZ.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CuboidPosZ.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.CuboidPosZ.Name = "CuboidPosZ";
            this.CuboidPosZ.Size = new System.Drawing.Size(53, 20);
            this.CuboidPosZ.TabIndex = 5;
            this.CuboidPosZ.ValueChanged += new System.EventHandler(this.CuboidPosZ_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y";
            // 
            // CuboidPosY
            // 
            this.CuboidPosY.DecimalPlaces = 2;
            this.CuboidPosY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.CuboidPosY.Location = new System.Drawing.Point(26, 58);
            this.CuboidPosY.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CuboidPosY.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.CuboidPosY.Name = "CuboidPosY";
            this.CuboidPosY.Size = new System.Drawing.Size(53, 20);
            this.CuboidPosY.TabIndex = 3;
            this.CuboidPosY.ValueChanged += new System.EventHandler(this.CuboidPosY_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // CuboidPosX
            // 
            this.CuboidPosX.DecimalPlaces = 2;
            this.CuboidPosX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.CuboidPosX.Location = new System.Drawing.Point(26, 32);
            this.CuboidPosX.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CuboidPosX.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.CuboidPosX.Name = "CuboidPosX";
            this.CuboidPosX.Size = new System.Drawing.Size(53, 20);
            this.CuboidPosX.TabIndex = 1;
            this.CuboidPosX.ValueChanged += new System.EventHandler(this.CuboidPosX_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position";
            // 
            // SphereGroupBox
            // 
            this.SphereGroupBox.Controls.Add(this.label64);
            this.SphereGroupBox.Controls.Add(this.SphereColor);
            this.SphereGroupBox.Controls.Add(this.label28);
            this.SphereGroupBox.Controls.Add(this.SphereRadius);
            this.SphereGroupBox.Controls.Add(this.label26);
            this.SphereGroupBox.Controls.Add(this.label27);
            this.SphereGroupBox.Controls.Add(this.label25);
            this.SphereGroupBox.Controls.Add(this.SphereLon);
            this.SphereGroupBox.Controls.Add(this.SphereLat);
            this.SphereGroupBox.Controls.Add(this.label13);
            this.SphereGroupBox.Controls.Add(this.SphereRotZ);
            this.SphereGroupBox.Controls.Add(this.label14);
            this.SphereGroupBox.Controls.Add(this.SphereRotY);
            this.SphereGroupBox.Controls.Add(this.label15);
            this.SphereGroupBox.Controls.Add(this.SphereRotX);
            this.SphereGroupBox.Controls.Add(this.label16);
            this.SphereGroupBox.Controls.Add(this.label17);
            this.SphereGroupBox.Controls.Add(this.SphereDimZ);
            this.SphereGroupBox.Controls.Add(this.label18);
            this.SphereGroupBox.Controls.Add(this.SphereDimY);
            this.SphereGroupBox.Controls.Add(this.label19);
            this.SphereGroupBox.Controls.Add(this.SphereDimX);
            this.SphereGroupBox.Controls.Add(this.label20);
            this.SphereGroupBox.Controls.Add(this.label21);
            this.SphereGroupBox.Controls.Add(this.SpherePosZ);
            this.SphereGroupBox.Controls.Add(this.label22);
            this.SphereGroupBox.Controls.Add(this.SpherePosY);
            this.SphereGroupBox.Controls.Add(this.label23);
            this.SphereGroupBox.Controls.Add(this.SpherePosX);
            this.SphereGroupBox.Controls.Add(this.label24);
            this.SphereGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SphereGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SphereGroupBox.Name = "SphereGroupBox";
            this.SphereGroupBox.Size = new System.Drawing.Size(186, 246);
            this.SphereGroupBox.TabIndex = 1;
            this.SphereGroupBox.TabStop = false;
            this.SphereGroupBox.Text = "Sphere properties";
            this.SphereGroupBox.Visible = false;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(9, 217);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(31, 13);
            this.label64.TabIndex = 52;
            this.label64.Text = "Color";
            // 
            // SphereColor
            // 
            this.SphereColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SphereColor.Location = new System.Drawing.Point(44, 214);
            this.SphereColor.Name = "SphereColor";
            this.SphereColor.Size = new System.Drawing.Size(20, 19);
            this.SphereColor.TabIndex = 51;
            this.SphereColor.TabStop = false;
            this.SphereColor.Click += new System.EventHandler(this.SphereColor_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(100, 186);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(15, 13);
            this.label28.TabIndex = 48;
            this.label28.Text = "R";
            // 
            // SphereRadius
            // 
            this.SphereRadius.DecimalPlaces = 2;
            this.SphereRadius.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.SphereRadius.Location = new System.Drawing.Point(121, 184);
            this.SphereRadius.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SphereRadius.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.SphereRadius.Name = "SphereRadius";
            this.SphereRadius.Size = new System.Drawing.Size(53, 20);
            this.SphereRadius.TabIndex = 47;
            this.SphereRadius.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.SphereRadius.ValueChanged += new System.EventHandler(this.SphereRadius_ValueChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(95, 159);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(25, 13);
            this.label26.TabIndex = 46;
            this.label26.Text = "Lon";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(95, 133);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(22, 13);
            this.label27.TabIndex = 45;
            this.label27.Text = "Lat";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(101, 114);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 13);
            this.label25.TabIndex = 44;
            this.label25.Text = "Parameters";
            // 
            // SphereLon
            // 
            this.SphereLon.Location = new System.Drawing.Point(121, 156);
            this.SphereLon.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SphereLon.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.SphereLon.Name = "SphereLon";
            this.SphereLon.Size = new System.Drawing.Size(53, 20);
            this.SphereLon.TabIndex = 43;
            this.SphereLon.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.SphereLon.ValueChanged += new System.EventHandler(this.SphereLon_ValueChanged);
            // 
            // SphereLat
            // 
            this.SphereLat.Location = new System.Drawing.Point(121, 130);
            this.SphereLat.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SphereLat.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.SphereLat.Name = "SphereLat";
            this.SphereLat.Size = new System.Drawing.Size(53, 20);
            this.SphereLat.TabIndex = 42;
            this.SphereLat.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.SphereLat.ValueChanged += new System.EventHandler(this.SphereLat_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Z";
            // 
            // SphereRotZ
            // 
            this.SphereRotZ.DecimalPlaces = 1;
            this.SphereRotZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SphereRotZ.Location = new System.Drawing.Point(29, 183);
            this.SphereRotZ.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.SphereRotZ.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.SphereRotZ.Name = "SphereRotZ";
            this.SphereRotZ.Size = new System.Drawing.Size(53, 20);
            this.SphereRotZ.TabIndex = 40;
            this.SphereRotZ.ValueChanged += new System.EventHandler(this.SphereRotZ_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Y";
            // 
            // SphereRotY
            // 
            this.SphereRotY.DecimalPlaces = 1;
            this.SphereRotY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SphereRotY.Location = new System.Drawing.Point(29, 156);
            this.SphereRotY.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.SphereRotY.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.SphereRotY.Name = "SphereRotY";
            this.SphereRotY.Size = new System.Drawing.Size(53, 20);
            this.SphereRotY.TabIndex = 38;
            this.SphereRotY.ValueChanged += new System.EventHandler(this.SphereRotY_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "X";
            // 
            // SphereRotX
            // 
            this.SphereRotX.DecimalPlaces = 1;
            this.SphereRotX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SphereRotX.Location = new System.Drawing.Point(29, 130);
            this.SphereRotX.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.SphereRotX.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.SphereRotX.Name = "SphereRotX";
            this.SphereRotX.Size = new System.Drawing.Size(53, 20);
            this.SphereRotX.TabIndex = 36;
            this.SphereRotX.ValueChanged += new System.EventHandler(this.SphereRotX_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Rotation";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(101, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Z";
            // 
            // SphereDimZ
            // 
            this.SphereDimZ.DecimalPlaces = 2;
            this.SphereDimZ.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.SphereDimZ.Location = new System.Drawing.Point(121, 85);
            this.SphereDimZ.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SphereDimZ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SphereDimZ.Name = "SphereDimZ";
            this.SphereDimZ.Size = new System.Drawing.Size(53, 20);
            this.SphereDimZ.TabIndex = 33;
            this.SphereDimZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SphereDimZ.ValueChanged += new System.EventHandler(this.SphereDimZ_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(101, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "Y";
            // 
            // SphereDimY
            // 
            this.SphereDimY.DecimalPlaces = 2;
            this.SphereDimY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.SphereDimY.Location = new System.Drawing.Point(121, 58);
            this.SphereDimY.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SphereDimY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SphereDimY.Name = "SphereDimY";
            this.SphereDimY.Size = new System.Drawing.Size(53, 20);
            this.SphereDimY.TabIndex = 31;
            this.SphereDimY.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SphereDimY.SystemColorsChanged += new System.EventHandler(this.SpherePosY_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(101, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "X";
            // 
            // SphereDimX
            // 
            this.SphereDimX.DecimalPlaces = 2;
            this.SphereDimX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.SphereDimX.Location = new System.Drawing.Point(121, 32);
            this.SphereDimX.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SphereDimX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SphereDimX.Name = "SphereDimX";
            this.SphereDimX.Size = new System.Drawing.Size(53, 20);
            this.SphereDimX.TabIndex = 29;
            this.SphereDimX.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SphereDimX.ValueChanged += new System.EventHandler(this.SphereDimX_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(98, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "Scale";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 87);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "Z";
            // 
            // SpherePosZ
            // 
            this.SpherePosZ.DecimalPlaces = 2;
            this.SpherePosZ.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.SpherePosZ.Location = new System.Drawing.Point(29, 85);
            this.SpherePosZ.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SpherePosZ.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.SpherePosZ.Name = "SpherePosZ";
            this.SpherePosZ.Size = new System.Drawing.Size(53, 20);
            this.SpherePosZ.TabIndex = 26;
            this.SpherePosZ.ValueChanged += new System.EventHandler(this.SpherePosZ_ValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 60);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "Y";
            // 
            // SpherePosY
            // 
            this.SpherePosY.DecimalPlaces = 2;
            this.SpherePosY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.SpherePosY.Location = new System.Drawing.Point(29, 58);
            this.SpherePosY.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SpherePosY.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.SpherePosY.Name = "SpherePosY";
            this.SpherePosY.Size = new System.Drawing.Size(53, 20);
            this.SpherePosY.TabIndex = 24;
            this.SpherePosY.ValueChanged += new System.EventHandler(this.SpherePosY_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 34);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 13);
            this.label23.TabIndex = 23;
            this.label23.Text = "X";
            // 
            // SpherePosX
            // 
            this.SpherePosX.DecimalPlaces = 2;
            this.SpherePosX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.SpherePosX.Location = new System.Drawing.Point(29, 32);
            this.SpherePosX.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SpherePosX.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.SpherePosX.Name = "SpherePosX";
            this.SpherePosX.Size = new System.Drawing.Size(53, 20);
            this.SpherePosX.TabIndex = 22;
            this.SpherePosX.ValueChanged += new System.EventHandler(this.SpherePosX_ValueChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 13);
            this.label24.TabIndex = 21;
            this.label24.Text = "Position";
            // 
            // AddFigureMenu
            // 
            this.AddFigureMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuboidToolStripMenuItem,
            this.sphereToolStripMenuItem,
            this.cylinderToolStripMenuItem,
            this.coneToolStripMenuItem});
            this.AddFigureMenu.Name = "AddFigureMenu";
            this.AddFigureMenu.Size = new System.Drawing.Size(119, 92);
            // 
            // cuboidToolStripMenuItem
            // 
            this.cuboidToolStripMenuItem.Name = "cuboidToolStripMenuItem";
            this.cuboidToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.cuboidToolStripMenuItem.Text = "Cuboid";
            this.cuboidToolStripMenuItem.Click += new System.EventHandler(this.cuboidToolStripMenuItem_Click);
            // 
            // sphereToolStripMenuItem
            // 
            this.sphereToolStripMenuItem.Name = "sphereToolStripMenuItem";
            this.sphereToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.sphereToolStripMenuItem.Text = "Sphere";
            this.sphereToolStripMenuItem.Click += new System.EventHandler(this.sphereToolStripMenuItem_Click);
            // 
            // cylinderToolStripMenuItem
            // 
            this.cylinderToolStripMenuItem.Name = "cylinderToolStripMenuItem";
            this.cylinderToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.cylinderToolStripMenuItem.Text = "Cylinder";
            this.cylinderToolStripMenuItem.Click += new System.EventHandler(this.cylinderToolStripMenuItem_Click);
            // 
            // coneToolStripMenuItem
            // 
            this.coneToolStripMenuItem.Name = "coneToolStripMenuItem";
            this.coneToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.coneToolStripMenuItem.Text = "Cone";
            this.coneToolStripMenuItem.Click += new System.EventHandler(this.coneToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 697);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(860, 640);
            this.Name = "Form1";
            this.Text = "3D Model Renderer";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FOVSlider)).EndInit();
            this.panel4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
            this.splitContainer9.ResumeLayout(false);
            this.LightGroupBox.ResumeLayout(false);
            this.LightGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LightPosZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightPosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightColor)).EndInit();
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FigureDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iFigureBindingSource)).EndInit();
            this.ConeGroupBox.ResumeLayout(false);
            this.ConeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConeRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConeHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConeDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConeRotZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConeRotY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConeRotX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConeDimZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConeDimY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConeDimX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConePosZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConePosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConePosX)).EndInit();
            this.CylinderGroupBox.ResumeLayout(false);
            this.CylinderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderRotZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderRotY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderRotX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderDimZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderDimY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderDimX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderPosZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderPosX)).EndInit();
            this.CuboidGroupBox.ResumeLayout(false);
            this.CuboidGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CuboidColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboidRotZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboidRotY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboidRotX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboidDimZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboidDimY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboidDimX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboidPosZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboidPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuboidPosX)).EndInit();
            this.SphereGroupBox.ResumeLayout(false);
            this.SphereGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SphereColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SphereRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SphereLon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SphereLat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SphereRotZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SphereRotY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SphereRotX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SphereDimZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SphereDimY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SphereDimX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpherePosZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpherePosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpherePosX)).EndInit();
            this.AddFigureMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.BindingSource iFigureBindingSource;
        private System.Windows.Forms.ContextMenuStrip AddFigureMenu;
        private System.Windows.Forms.ToolStripMenuItem cuboidToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripLabel FPSLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillTrianglesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sphereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backfaceCullingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zbufferingToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button ResetCameraButton;
        private System.Windows.Forms.Button RemoveCameraButton;
        private System.Windows.Forms.Button AddCameraButton;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label FOVLabel;
        private System.Windows.Forms.TrackBar FOVSlider;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox CameraListBox;
        private System.Windows.Forms.NumericUpDown CameraN;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown CameraF;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ToolStripMenuItem saveSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cylinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coneToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.Button RemoveFigureButton;
        private System.Windows.Forms.Button AddFigureButton;
        private System.Windows.Forms.DataGridView FigureDataGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Visibility;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox ConeGroupBox;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.PictureBox ConeColor;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.NumericUpDown ConeRadius;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.NumericUpDown ConeHeight;
        private System.Windows.Forms.NumericUpDown ConeDiv;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.NumericUpDown ConeRotZ;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.NumericUpDown ConeRotY;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.NumericUpDown ConeRotX;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.NumericUpDown ConeDimZ;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.NumericUpDown ConeDimY;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.NumericUpDown ConeDimX;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.NumericUpDown ConePosZ;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.NumericUpDown ConePosY;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.NumericUpDown ConePosX;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.GroupBox CylinderGroupBox;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.PictureBox CylinderColor;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.NumericUpDown CylinderRadius;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.NumericUpDown CylinderHeight;
        private System.Windows.Forms.NumericUpDown CylinderDiv;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.NumericUpDown CylinderRotZ;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.NumericUpDown CylinderRotY;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.NumericUpDown CylinderRotX;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.NumericUpDown CylinderDimZ;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.NumericUpDown CylinderDimY;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.NumericUpDown CylinderDimX;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.NumericUpDown CylinderPosZ;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.NumericUpDown CylinderPosY;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.NumericUpDown CylinderPosX;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.GroupBox CuboidGroupBox;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.PictureBox CuboidColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown CuboidRotZ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown CuboidRotY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown CuboidRotX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown CuboidDimZ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown CuboidDimY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown CuboidDimX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown CuboidPosZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown CuboidPosY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown CuboidPosX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox SphereGroupBox;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.PictureBox SphereColor;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown SphereRadius;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown SphereLon;
        private System.Windows.Forms.NumericUpDown SphereLat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown SphereRotZ;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown SphereRotY;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown SphereRotX;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown SphereDimZ;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown SphereDimY;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown SphereDimX;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown SpherePosZ;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown SpherePosY;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown SpherePosX;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ToolStripMenuItem perspectiveCorrectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyrusBeckCullingToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.Button RemoveLightButton;
        private System.Windows.Forms.Button AddLightButton;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.GroupBox LightGroupBox;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.NumericUpDown LightPosZ;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.NumericUpDown LightPosY;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.NumericUpDown LightPosX;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.NumericUpDown LightRange;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.NumericUpDown LightIntensity;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.PictureBox LightColor;
        private System.Windows.Forms.ListBox LightListBox;
    }
}

