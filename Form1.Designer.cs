﻿namespace Vision_inspection
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.ha_windos_0 = new HalconDotNet.HWindowControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ha_windos_1 = new HalconDotNet.HWindowControl();
            this.ha_windos_2 = new HalconDotNet.HWindowControl();
            this.ha_windos_3 = new HalconDotNet.HWindowControl();
            this.camera_set = new System.Windows.Forms.TabControl();
            this.camera_set_init = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.camera_set_set = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.最大化 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.date_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.ha_windos_box = new System.Windows.Forms.Panel();
            this.ha_windos_box_info = new System.Windows.Forms.Label();
            this.info_list = new System.Windows.Forms.ListView();
            this.camera_set.SuspendLayout();
            this.camera_set_init.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.camera_set_set.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.ha_windos_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // ha_windos_0
            // 
            this.ha_windos_0.BackColor = System.Drawing.Color.SkyBlue;
            this.ha_windos_0.BorderColor = System.Drawing.Color.SkyBlue;
            this.ha_windos_0.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.ha_windos_0.Location = new System.Drawing.Point(0, 3);
            this.ha_windos_0.Name = "ha_windos_0";
            this.ha_windos_0.Size = new System.Drawing.Size(300, 250);
            this.ha_windos_0.TabIndex = 0;
            this.ha_windos_0.WindowSize = new System.Drawing.Size(300, 250);
            this.ha_windos_0.HMouseUp += new HalconDotNet.HMouseEventHandler(this.ha_windos_0_HMouseUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ha_windos_1
            // 
            this.ha_windos_1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ha_windos_1.BackColor = System.Drawing.Color.SkyBlue;
            this.ha_windos_1.BorderColor = System.Drawing.Color.SkyBlue;
            this.ha_windos_1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.ha_windos_1.Location = new System.Drawing.Point(304, 3);
            this.ha_windos_1.Name = "ha_windos_1";
            this.ha_windos_1.Size = new System.Drawing.Size(300, 250);
            this.ha_windos_1.TabIndex = 1;
            this.ha_windos_1.WindowSize = new System.Drawing.Size(300, 250);
            this.ha_windos_1.HMouseUp += new HalconDotNet.HMouseEventHandler(this.ha_windos_1_HMouseUp);
            // 
            // ha_windos_2
            // 
            this.ha_windos_2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ha_windos_2.BackColor = System.Drawing.Color.SkyBlue;
            this.ha_windos_2.BorderColor = System.Drawing.Color.SkyBlue;
            this.ha_windos_2.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.ha_windos_2.Location = new System.Drawing.Point(0, 258);
            this.ha_windos_2.Name = "ha_windos_2";
            this.ha_windos_2.Size = new System.Drawing.Size(300, 250);
            this.ha_windos_2.TabIndex = 2;
            this.ha_windos_2.WindowSize = new System.Drawing.Size(300, 250);
            this.ha_windos_2.HMouseUp += new HalconDotNet.HMouseEventHandler(this.ha_windos_2_HMouseUp);
            // 
            // ha_windos_3
            // 
            this.ha_windos_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ha_windos_3.BackColor = System.Drawing.Color.SkyBlue;
            this.ha_windos_3.BorderColor = System.Drawing.Color.SkyBlue;
            this.ha_windos_3.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.ha_windos_3.Location = new System.Drawing.Point(304, 258);
            this.ha_windos_3.Name = "ha_windos_3";
            this.ha_windos_3.Size = new System.Drawing.Size(300, 250);
            this.ha_windos_3.TabIndex = 3;
            this.ha_windos_3.WindowSize = new System.Drawing.Size(300, 250);
            this.ha_windos_3.HMouseUp += new HalconDotNet.HMouseEventHandler(this.ha_windos_3_HMouseUp);
            // 
            // camera_set
            // 
            this.camera_set.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.camera_set.Controls.Add(this.camera_set_init);
            this.camera_set.Controls.Add(this.camera_set_set);
            this.camera_set.Controls.Add(this.tabPage3);
            this.camera_set.ImageList = this.imageList1;
            this.camera_set.Location = new System.Drawing.Point(607, 25);
            this.camera_set.Margin = new System.Windows.Forms.Padding(0);
            this.camera_set.Name = "camera_set";
            this.camera_set.SelectedIndex = 0;
            this.camera_set.Size = new System.Drawing.Size(293, 250);
            this.camera_set.TabIndex = 6;
            // 
            // camera_set_init
            // 
            this.camera_set_init.Controls.Add(this.groupBox1);
            this.camera_set_init.Controls.Add(this.label3);
            this.camera_set_init.Controls.Add(this.pictureBox2);
            this.camera_set_init.Controls.Add(this.label2);
            this.camera_set_init.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.camera_set_init.ImageIndex = 2;
            this.camera_set_init.Location = new System.Drawing.Point(4, 23);
            this.camera_set_init.Name = "camera_set_init";
            this.camera_set_init.Size = new System.Drawing.Size(285, 223);
            this.camera_set_init.TabIndex = 0;
            this.camera_set_init.Text = "初始化";
            this.camera_set_init.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(284, 163);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设备列表";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 14);
            this.label10.TabIndex = 3;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 14);
            this.label8.TabIndex = 1;
            this.label8.Text = "label8";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(30, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "[0] HD WebCam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "下一步";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(233, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 14);
            this.label2.TabIndex = 1;
            // 
            // camera_set_set
            // 
            this.camera_set_set.Controls.Add(this.label5);
            this.camera_set_set.Controls.Add(this.label4);
            this.camera_set_set.Controls.Add(this.pictureBox4);
            this.camera_set_set.Controls.Add(this.pictureBox3);
            this.camera_set_set.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.camera_set_set.ImageIndex = 4;
            this.camera_set_set.Location = new System.Drawing.Point(4, 23);
            this.camera_set_set.Name = "camera_set_set";
            this.camera_set_set.Padding = new System.Windows.Forms.Padding(3);
            this.camera_set_set.Size = new System.Drawing.Size(285, 223);
            this.camera_set_set.TabIndex = 1;
            this.camera_set_set.Text = "参数设置";
            this.camera_set_set.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "上一步";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "下一步";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-7, 169);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(233, 169);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.pictureBox5);
            this.tabPage3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(285, 223);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "第三步";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "上一步";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(-7, 169);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(56, 37);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "flower.png");
            this.imageList1.Images.SetKeyName(1, "video-camera.png");
            this.imageList1.Images.SetKeyName(2, "comment-video.png");
            this.imageList1.Images.SetKeyName(3, "scan.png");
            this.imageList1.Images.SetKeyName(4, "shutter.png");
            this.imageList1.Images.SetKeyName(5, "shutter-outlined.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton4,
            this.最大化,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(900, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.DoubleClick += new System.EventHandler(this.toolStrip1_DoubleClick);
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            this.toolStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseMove);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 25);
            this.toolStripButton2.Text = "用户";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 25);
            this.toolStripButton1.Text = "导入";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(60, 25);
            this.toolStripButton3.Text = "保存";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(30, 25);
            this.toolStripButton4.Text = "退出";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // 最大化
            // 
            this.最大化.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.最大化.AutoSize = false;
            this.最大化.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.最大化.Image = ((System.Drawing.Image)(resources.GetObject("最大化.Image")));
            this.最大化.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.最大化.Name = "最大化";
            this.最大化.Size = new System.Drawing.Size(30, 25);
            this.最大化.Text = "最大化";
            this.最大化.Click += new System.EventHandler(this.最大化_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton5.AutoSize = false;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(30, 25);
            this.toolStripButton5.Text = "最小化";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusStrip1.AutoSize = false;
            this.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.date_time});
            this.StatusStrip1.Location = new System.Drawing.Point(607, 513);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(289, 20);
            this.StatusStrip1.SizingGrip = false;
            this.StatusStrip1.TabIndex = 7;
            // 
            // date_time
            // 
            this.date_time.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(274, 15);
            this.date_time.Spring = true;
            this.date_time.Text = "2020/7/1 星期三 10:49:00";
            // 
            // ha_windos_box
            // 
            this.ha_windos_box.BackColor = System.Drawing.SystemColors.Window;
            this.ha_windos_box.Controls.Add(this.ha_windos_box_info);
            this.ha_windos_box.Controls.Add(this.ha_windos_3);
            this.ha_windos_box.Controls.Add(this.ha_windos_2);
            this.ha_windos_box.Controls.Add(this.ha_windos_0);
            this.ha_windos_box.Controls.Add(this.ha_windos_1);
            this.ha_windos_box.Location = new System.Drawing.Point(0, 25);
            this.ha_windos_box.Margin = new System.Windows.Forms.Padding(0);
            this.ha_windos_box.Name = "ha_windos_box";
            this.ha_windos_box.Size = new System.Drawing.Size(607, 505);
            this.ha_windos_box.TabIndex = 10;
            // 
            // ha_windos_box_info
            // 
            this.ha_windos_box_info.AutoSize = true;
            this.ha_windos_box_info.Location = new System.Drawing.Point(14, 17);
            this.ha_windos_box_info.Name = "ha_windos_box_info";
            this.ha_windos_box_info.Size = new System.Drawing.Size(41, 12);
            this.ha_windos_box_info.TabIndex = 4;
            this.ha_windos_box_info.Text = "label1";
            // 
            // info_list
            // 
            this.info_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.info_list.HideSelection = false;
            this.info_list.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.info_list.Location = new System.Drawing.Point(607, 277);
            this.info_list.Margin = new System.Windows.Forms.Padding(0);
            this.info_list.Name = "info_list";
            this.info_list.Size = new System.Drawing.Size(289, 236);
            this.info_list.TabIndex = 11;
            this.info_list.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 535);
            this.Controls.Add(this.info_list);
            this.Controls.Add(this.ha_windos_box);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.camera_set);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.camera_set.ResumeLayout(false);
            this.camera_set_init.ResumeLayout(false);
            this.camera_set_init.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.camera_set_set.ResumeLayout(false);
            this.camera_set_set.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ha_windos_box.ResumeLayout(false);
            this.ha_windos_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage camera_set_init;
        private System.Windows.Forms.TabPage camera_set_set;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripButton 最大化;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel date_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Panel ha_windos_box;
        public System.Windows.Forms.TabControl camera_set;
        public System.Windows.Forms.Label ha_windos_box_info;
        public System.Windows.Forms.ListView info_list;
        public HalconDotNet.HWindowControl ha_windos_0;
        public HalconDotNet.HWindowControl ha_windos_1;
        public HalconDotNet.HWindowControl ha_windos_2;
        public HalconDotNet.HWindowControl ha_windos_3;
    }
}

