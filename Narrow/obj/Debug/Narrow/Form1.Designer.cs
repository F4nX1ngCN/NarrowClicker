namespace Narrow
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
            this.Panel_Title_Move = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_exit_btn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabBox = new System.Windows.Forms.TabControl();
            this.TabBoxA = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_RKeyBind = new System.Windows.Forms.Label();
            this.label_Rmax_CPS = new System.Windows.Forms.Label();
            this.label_Rmin_CPS = new System.Windows.Forms.Label();
            this.Trackbar_CPS_RMax = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.Trackbar_CPS_RMin = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckBox_RClick = new System.Windows.Forms.CheckBox();
            this.GB_LClicker = new System.Windows.Forms.GroupBox();
            this.label_Lmax_CPS = new System.Windows.Forms.Label();
            this.Trackbar_CPS_LMax = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_LKeyBind = new System.Windows.Forms.Label();
            this.label_Lmin_CPS = new System.Windows.Forms.Label();
            this.Trackbar_CPS_LMin = new System.Windows.Forms.TrackBar();
            this.CheckBox_BlockHit = new System.Windows.Forms.CheckBox();
            this.CheckBox_LClick = new System.Windows.Forms.CheckBox();
            this.TabBoxB = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Destruct = new System.Windows.Forms.Button();
            this.TabBoxC = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TimerR_CPS = new System.Windows.Forms.Timer(this.components);
            this.TimerL_CPS = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_Title_Move.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TabBox.SuspendLayout();
            this.TabBoxA.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_CPS_RMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_CPS_RMin)).BeginInit();
            this.GB_LClicker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_CPS_LMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_CPS_LMin)).BeginInit();
            this.TabBoxB.SuspendLayout();
            this.TabBoxC.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Title_Move
            // 
            this.Panel_Title_Move.Controls.Add(this.pictureBox2);
            this.Panel_Title_Move.Controls.Add(this.pic_exit_btn);
            this.Panel_Title_Move.Controls.Add(this.pictureBox1);
            this.Panel_Title_Move.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Title_Move.Location = new System.Drawing.Point(0, 0);
            this.Panel_Title_Move.Name = "Panel_Title_Move";
            this.Panel_Title_Move.Size = new System.Drawing.Size(512, 35);
            this.Panel_Title_Move.TabIndex = 0;
            this.Panel_Title_Move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Title_Move_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(436, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pic_exit_btn
            // 
            this.pic_exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("pic_exit_btn.Image")));
            this.pic_exit_btn.Location = new System.Drawing.Point(466, 9);
            this.pic_exit_btn.Name = "pic_exit_btn";
            this.pic_exit_btn.Size = new System.Drawing.Size(18, 18);
            this.pic_exit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_exit_btn.TabIndex = 1;
            this.pic_exit_btn.TabStop = false;
            this.pic_exit_btn.Click += new System.EventHandler(this.pic_exit_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(357, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "@NarrowClicker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // TabBox
            // 
            this.TabBox.Controls.Add(this.TabBoxA);
            this.TabBox.Controls.Add(this.TabBoxB);
            this.TabBox.Controls.Add(this.TabBoxC);
            this.TabBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabBox.Location = new System.Drawing.Point(12, 53);
            this.TabBox.Margin = new System.Windows.Forms.Padding(0);
            this.TabBox.Name = "TabBox";
            this.TabBox.Padding = new System.Drawing.Point(0, 0);
            this.TabBox.SelectedIndex = 0;
            this.TabBox.Size = new System.Drawing.Size(489, 236);
            this.TabBox.TabIndex = 5;
            // 
            // TabBoxA
            // 
            this.TabBoxA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabBoxA.Controls.Add(this.groupBox1);
            this.TabBoxA.Controls.Add(this.GB_LClicker);
            this.TabBoxA.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabBoxA.ForeColor = System.Drawing.Color.Black;
            this.TabBoxA.Location = new System.Drawing.Point(4, 28);
            this.TabBoxA.Name = "TabBoxA";
            this.TabBoxA.Padding = new System.Windows.Forms.Padding(3);
            this.TabBoxA.Size = new System.Drawing.Size(481, 204);
            this.TabBoxA.TabIndex = 0;
            this.TabBoxA.Text = "Clicker";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_RKeyBind);
            this.groupBox1.Controls.Add(this.label_Rmax_CPS);
            this.groupBox1.Controls.Add(this.label_Rmin_CPS);
            this.groupBox1.Controls.Add(this.Trackbar_CPS_RMax);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Trackbar_CPS_RMin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CheckBox_RClick);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Salmon;
            this.groupBox1.Location = new System.Drawing.Point(250, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(214, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RightClicker";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.GB_Clicker_Paint);
            // 
            // label_RKeyBind
            // 
            this.label_RKeyBind.AutoSize = true;
            this.label_RKeyBind.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_RKeyBind.ForeColor = System.Drawing.Color.White;
            this.label_RKeyBind.Location = new System.Drawing.Point(98, 36);
            this.label_RKeyBind.Name = "label_RKeyBind";
            this.label_RKeyBind.Size = new System.Drawing.Size(72, 17);
            this.label_RKeyBind.TabIndex = 10;
            this.label_RKeyBind.Text = "Bind:None";
            this.label_RKeyBind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_RKeyBind.Click += new System.EventHandler(this.label_RKeyBind_Click);
            // 
            // label_Rmax_CPS
            // 
            this.label_Rmax_CPS.AutoSize = true;
            this.label_Rmax_CPS.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Rmax_CPS.ForeColor = System.Drawing.Color.White;
            this.label_Rmax_CPS.Location = new System.Drawing.Point(181, 139);
            this.label_Rmax_CPS.Name = "label_Rmax_CPS";
            this.label_Rmax_CPS.Size = new System.Drawing.Size(20, 22);
            this.label_Rmax_CPS.TabIndex = 9;
            this.label_Rmax_CPS.Text = "1";
            this.label_Rmax_CPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Rmin_CPS
            // 
            this.label_Rmin_CPS.AutoSize = true;
            this.label_Rmin_CPS.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Rmin_CPS.ForeColor = System.Drawing.Color.White;
            this.label_Rmin_CPS.Location = new System.Drawing.Point(181, 96);
            this.label_Rmin_CPS.Name = "label_Rmin_CPS";
            this.label_Rmin_CPS.Size = new System.Drawing.Size(20, 22);
            this.label_Rmin_CPS.TabIndex = 9;
            this.label_Rmin_CPS.Text = "1";
            this.label_Rmin_CPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Trackbar_CPS_RMax
            // 
            this.Trackbar_CPS_RMax.Location = new System.Drawing.Point(50, 135);
            this.Trackbar_CPS_RMax.Maximum = 20;
            this.Trackbar_CPS_RMax.Minimum = 1;
            this.Trackbar_CPS_RMax.Name = "Trackbar_CPS_RMax";
            this.Trackbar_CPS_RMax.Size = new System.Drawing.Size(123, 45);
            this.Trackbar_CPS_RMax.TabIndex = 8;
            this.Trackbar_CPS_RMax.Value = 1;
            this.Trackbar_CPS_RMax.Scroll += new System.EventHandler(this.Trackbar_CPS_RMax_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Max";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Trackbar_CPS_RMin
            // 
            this.Trackbar_CPS_RMin.Location = new System.Drawing.Point(50, 92);
            this.Trackbar_CPS_RMin.Maximum = 20;
            this.Trackbar_CPS_RMin.Minimum = 1;
            this.Trackbar_CPS_RMin.Name = "Trackbar_CPS_RMin";
            this.Trackbar_CPS_RMin.Size = new System.Drawing.Size(123, 45);
            this.Trackbar_CPS_RMin.TabIndex = 8;
            this.Trackbar_CPS_RMin.Value = 1;
            this.Trackbar_CPS_RMin.Scroll += new System.EventHandler(this.Trackbar_CPS_RMin_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Min";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckBox_RClick
            // 
            this.CheckBox_RClick.AutoSize = true;
            this.CheckBox_RClick.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox_RClick.ForeColor = System.Drawing.Color.White;
            this.CheckBox_RClick.Location = new System.Drawing.Point(15, 32);
            this.CheckBox_RClick.Name = "CheckBox_RClick";
            this.CheckBox_RClick.Size = new System.Drawing.Size(75, 24);
            this.CheckBox_RClick.TabIndex = 3;
            this.CheckBox_RClick.Text = "Toggle";
            this.CheckBox_RClick.UseVisualStyleBackColor = true;
            // 
            // GB_LClicker
            // 
            this.GB_LClicker.Controls.Add(this.label_Lmax_CPS);
            this.GB_LClicker.Controls.Add(this.Trackbar_CPS_LMax);
            this.GB_LClicker.Controls.Add(this.label8);
            this.GB_LClicker.Controls.Add(this.label2);
            this.GB_LClicker.Controls.Add(this.label_LKeyBind);
            this.GB_LClicker.Controls.Add(this.label_Lmin_CPS);
            this.GB_LClicker.Controls.Add(this.Trackbar_CPS_LMin);
            this.GB_LClicker.Controls.Add(this.CheckBox_BlockHit);
            this.GB_LClicker.Controls.Add(this.CheckBox_LClick);
            this.GB_LClicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GB_LClicker.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GB_LClicker.ForeColor = System.Drawing.Color.Salmon;
            this.GB_LClicker.Location = new System.Drawing.Point(12, 9);
            this.GB_LClicker.Name = "GB_LClicker";
            this.GB_LClicker.Padding = new System.Windows.Forms.Padding(0);
            this.GB_LClicker.Size = new System.Drawing.Size(207, 183);
            this.GB_LClicker.TabIndex = 0;
            this.GB_LClicker.TabStop = false;
            this.GB_LClicker.Text = "LeftClicker";
            this.GB_LClicker.Paint += new System.Windows.Forms.PaintEventHandler(this.GB_Clicker_Paint);
            // 
            // label_Lmax_CPS
            // 
            this.label_Lmax_CPS.AutoSize = true;
            this.label_Lmax_CPS.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Lmax_CPS.ForeColor = System.Drawing.Color.White;
            this.label_Lmax_CPS.Location = new System.Drawing.Point(176, 136);
            this.label_Lmax_CPS.Name = "label_Lmax_CPS";
            this.label_Lmax_CPS.Size = new System.Drawing.Size(20, 22);
            this.label_Lmax_CPS.TabIndex = 9;
            this.label_Lmax_CPS.Text = "1";
            this.label_Lmax_CPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Trackbar_CPS_LMax
            // 
            this.Trackbar_CPS_LMax.Location = new System.Drawing.Point(47, 135);
            this.Trackbar_CPS_LMax.Maximum = 20;
            this.Trackbar_CPS_LMax.Minimum = 1;
            this.Trackbar_CPS_LMax.Name = "Trackbar_CPS_LMax";
            this.Trackbar_CPS_LMax.Size = new System.Drawing.Size(123, 45);
            this.Trackbar_CPS_LMax.TabIndex = 8;
            this.Trackbar_CPS_LMax.Value = 1;
            this.Trackbar_CPS_LMax.Scroll += new System.EventHandler(this.Trackbar_CPS_LMax_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Max";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Min";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_LKeyBind
            // 
            this.label_LKeyBind.AutoSize = true;
            this.label_LKeyBind.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_LKeyBind.ForeColor = System.Drawing.Color.White;
            this.label_LKeyBind.Location = new System.Drawing.Point(95, 36);
            this.label_LKeyBind.Name = "label_LKeyBind";
            this.label_LKeyBind.Size = new System.Drawing.Size(72, 17);
            this.label_LKeyBind.TabIndex = 6;
            this.label_LKeyBind.Text = "Bind:None";
            this.label_LKeyBind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_LKeyBind.Click += new System.EventHandler(this.label_LKeyBind_Click);
            // 
            // label_Lmin_CPS
            // 
            this.label_Lmin_CPS.AutoSize = true;
            this.label_Lmin_CPS.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Lmin_CPS.ForeColor = System.Drawing.Color.White;
            this.label_Lmin_CPS.Location = new System.Drawing.Point(176, 92);
            this.label_Lmin_CPS.Name = "label_Lmin_CPS";
            this.label_Lmin_CPS.Size = new System.Drawing.Size(20, 22);
            this.label_Lmin_CPS.TabIndex = 6;
            this.label_Lmin_CPS.Text = "1";
            this.label_Lmin_CPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Trackbar_CPS_LMin
            // 
            this.Trackbar_CPS_LMin.Location = new System.Drawing.Point(47, 92);
            this.Trackbar_CPS_LMin.Maximum = 20;
            this.Trackbar_CPS_LMin.Minimum = 1;
            this.Trackbar_CPS_LMin.Name = "Trackbar_CPS_LMin";
            this.Trackbar_CPS_LMin.Size = new System.Drawing.Size(123, 45);
            this.Trackbar_CPS_LMin.TabIndex = 5;
            this.Trackbar_CPS_LMin.Value = 1;
            this.Trackbar_CPS_LMin.Scroll += new System.EventHandler(this.Trackbar_CPS_LMin_Scroll);
            // 
            // CheckBox_BlockHit
            // 
            this.CheckBox_BlockHit.AutoSize = true;
            this.CheckBox_BlockHit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox_BlockHit.ForeColor = System.Drawing.Color.White;
            this.CheckBox_BlockHit.Location = new System.Drawing.Point(12, 62);
            this.CheckBox_BlockHit.Name = "CheckBox_BlockHit";
            this.CheckBox_BlockHit.Size = new System.Drawing.Size(85, 24);
            this.CheckBox_BlockHit.TabIndex = 4;
            this.CheckBox_BlockHit.Text = "BlockHit";
            this.CheckBox_BlockHit.UseVisualStyleBackColor = true;
            // 
            // CheckBox_LClick
            // 
            this.CheckBox_LClick.AutoSize = true;
            this.CheckBox_LClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CheckBox_LClick.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox_LClick.ForeColor = System.Drawing.Color.White;
            this.CheckBox_LClick.Location = new System.Drawing.Point(12, 32);
            this.CheckBox_LClick.Name = "CheckBox_LClick";
            this.CheckBox_LClick.Size = new System.Drawing.Size(75, 24);
            this.CheckBox_LClick.TabIndex = 3;
            this.CheckBox_LClick.Text = "Toggle";
            this.CheckBox_LClick.UseVisualStyleBackColor = false;
            // 
            // TabBoxB
            // 
            this.TabBoxB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabBoxB.Controls.Add(this.label7);
            this.TabBoxB.Controls.Add(this.btn_Destruct);
            this.TabBoxB.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabBoxB.Location = new System.Drawing.Point(4, 28);
            this.TabBoxB.Name = "TabBoxB";
            this.TabBoxB.Padding = new System.Windows.Forms.Padding(3);
            this.TabBoxB.Size = new System.Drawing.Size(481, 204);
            this.TabBoxB.TabIndex = 1;
            this.TabBoxB.Text = "Self Destruction";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(138, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Click Here to Destruct";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btn_Destruct
            // 
            this.btn_Destruct.Location = new System.Drawing.Point(185, 148);
            this.btn_Destruct.Name = "btn_Destruct";
            this.btn_Destruct.Size = new System.Drawing.Size(100, 29);
            this.btn_Destruct.TabIndex = 0;
            this.btn_Destruct.Text = "Destruct";
            this.btn_Destruct.UseVisualStyleBackColor = true;
            this.btn_Destruct.Click += new System.EventHandler(this.btn_Destruct_Click);
            // 
            // TabBoxC
            // 
            this.TabBoxC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabBoxC.Controls.Add(this.label6);
            this.TabBoxC.Controls.Add(this.label5);
            this.TabBoxC.Location = new System.Drawing.Point(4, 28);
            this.TabBoxC.Name = "TabBoxC";
            this.TabBoxC.Padding = new System.Windows.Forms.Padding(3);
            this.TabBoxC.Size = new System.Drawing.Size(481, 204);
            this.TabBoxC.TabIndex = 2;
            this.TabBoxC.Text = "About";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Location = new System.Drawing.Point(271, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Version: 1.0.0 (Release)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(138, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Powered By Smile2Cheat";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // TimerR_CPS
            // 
            this.TimerR_CPS.Enabled = true;
            this.TimerR_CPS.Interval = 1;
            this.TimerR_CPS.Tick += new System.EventHandler(this.TimerR_CPS_Tick);
            // 
            // TimerL_CPS
            // 
            this.TimerL_CPS.Enabled = true;
            this.TimerL_CPS.Interval = 1;
            this.TimerL_CPS.Tick += new System.EventHandler(this.TimerL_CPS_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 2);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(512, 335);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TabBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Panel_Title_Move);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NARROW";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_Title_Move.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TabBox.ResumeLayout(false);
            this.TabBoxA.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_CPS_RMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_CPS_RMin)).EndInit();
            this.GB_LClicker.ResumeLayout(false);
            this.GB_LClicker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_CPS_LMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_CPS_LMin)).EndInit();
            this.TabBoxB.ResumeLayout(false);
            this.TabBoxB.PerformLayout();
            this.TabBoxC.ResumeLayout(false);
            this.TabBoxC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Title_Move;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_exit_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TabBox;
        private System.Windows.Forms.TabPage TabBoxB;
        private System.Windows.Forms.TabPage TabBoxC;
        private System.Windows.Forms.CheckBox CheckBox_BlockHit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Destruct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar Trackbar_CPS_LMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Lmin_CPS;
        private System.Windows.Forms.Label label_Lmax_CPS;
        private System.Windows.Forms.TrackBar Trackbar_CPS_LMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar Trackbar_CPS_RMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Rmax_CPS;
        private System.Windows.Forms.Label label_Rmin_CPS;
        private System.Windows.Forms.TrackBar Trackbar_CPS_RMax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer TimerL_CPS;
        private System.Windows.Forms.Timer TimerR_CPS;
        public System.Windows.Forms.Label label_LKeyBind;
        public System.Windows.Forms.Label label_RKeyBind;
        public System.Windows.Forms.CheckBox CheckBox_LClick;
        public System.Windows.Forms.CheckBox CheckBox_RClick;
        public System.Windows.Forms.TabPage TabBoxA;
        public System.Windows.Forms.GroupBox GB_LClicker;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

