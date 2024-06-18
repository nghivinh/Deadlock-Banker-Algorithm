namespace DEADLOCK_ALGORITHM
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlAlloc = new System.Windows.Forms.Panel();
            this.lblAllocC = new System.Windows.Forms.Label();
            this.lblAllocB = new System.Windows.Forms.Label();
            this.lblAllocA = new System.Windows.Forms.Label();
            this.lblMaxC = new System.Windows.Forms.Label();
            this.lblMaxB = new System.Windows.Forms.Label();
            this.lblMaxA = new System.Windows.Forms.Label();
            this.lblNeedC = new System.Windows.Forms.Label();
            this.lblNeedB = new System.Windows.Forms.Label();
            this.lblNeedA = new System.Windows.Forms.Label();
            this.pnlAvai = new System.Windows.Forms.Panel();
            this.pnlWork = new System.Windows.Forms.Panel();
            this.lblWorkC = new System.Windows.Forms.Label();
            this.lblWorkB = new System.Windows.Forms.Label();
            this.lblWorkA = new System.Windows.Forms.Label();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.pnlReq = new System.Windows.Forms.Panel();
            this.cbbReq = new System.Windows.Forms.ComboBox();
            this.rabtnYes = new System.Windows.Forms.RadioButton();
            this.rabtnNo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAvaiA = new System.Windows.Forms.Label();
            this.lblAvaiB = new System.Windows.Forms.Label();
            this.lblAvaiC = new System.Windows.Forms.Label();
            this.pnlReqq = new System.Windows.Forms.Panel();
            this.pnlAvaii = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.cbbBgColor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudProcess = new System.Windows.Forms.NumericUpDown();
            this.pnlWorkk = new System.Windows.Forms.Panel();
            this.pnlAllocc = new System.Windows.Forms.Panel();
            this.pnlMaxx = new System.Windows.Forms.Panel();
            this.pnlNeedd = new System.Windows.Forms.Panel();
            this.pnlNeed = new System.Windows.Forms.Panel();
            this.pnlMax = new System.Windows.Forms.Panel();
            this.fpnlResult = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnRandomE = new System.Windows.Forms.Button();
            this.chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlReqq.SuspendLayout();
            this.pnlAvaii.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProcess)).BeginInit();
            this.pnlWorkk.SuspendLayout();
            this.pnlAllocc.SuspendLayout();
            this.pnlMaxx.SuspendLayout();
            this.pnlNeedd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAlloc
            // 
            this.pnlAlloc.AllowDrop = true;
            this.pnlAlloc.AutoScroll = true;
            this.pnlAlloc.BackColor = System.Drawing.Color.Yellow;
            this.pnlAlloc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAlloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAlloc.Location = new System.Drawing.Point(23, 143);
            this.pnlAlloc.Name = "pnlAlloc";
            this.pnlAlloc.Size = new System.Drawing.Size(184, 222);
            this.pnlAlloc.TabIndex = 0;
            // 
            // lblAllocC
            // 
            this.lblAllocC.AutoSize = true;
            this.lblAllocC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllocC.ForeColor = System.Drawing.Color.Black;
            this.lblAllocC.Location = new System.Drawing.Point(130, 0);
            this.lblAllocC.Name = "lblAllocC";
            this.lblAllocC.Size = new System.Drawing.Size(21, 20);
            this.lblAllocC.TabIndex = 8;
            this.lblAllocC.Text = "C";
            // 
            // lblAllocB
            // 
            this.lblAllocB.AutoSize = true;
            this.lblAllocB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllocB.ForeColor = System.Drawing.Color.Black;
            this.lblAllocB.Location = new System.Drawing.Point(85, 0);
            this.lblAllocB.Name = "lblAllocB";
            this.lblAllocB.Size = new System.Drawing.Size(21, 20);
            this.lblAllocB.TabIndex = 8;
            this.lblAllocB.Text = "B";
            // 
            // lblAllocA
            // 
            this.lblAllocA.AutoSize = true;
            this.lblAllocA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllocA.ForeColor = System.Drawing.Color.Black;
            this.lblAllocA.Location = new System.Drawing.Point(40, 0);
            this.lblAllocA.Name = "lblAllocA";
            this.lblAllocA.Size = new System.Drawing.Size(21, 20);
            this.lblAllocA.TabIndex = 8;
            this.lblAllocA.Text = "A";
            // 
            // lblMaxC
            // 
            this.lblMaxC.AutoSize = true;
            this.lblMaxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxC.Location = new System.Drawing.Point(130, 0);
            this.lblMaxC.Name = "lblMaxC";
            this.lblMaxC.Size = new System.Drawing.Size(21, 20);
            this.lblMaxC.TabIndex = 8;
            this.lblMaxC.Text = "C";
            // 
            // lblMaxB
            // 
            this.lblMaxB.AutoSize = true;
            this.lblMaxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxB.Location = new System.Drawing.Point(85, 0);
            this.lblMaxB.Name = "lblMaxB";
            this.lblMaxB.Size = new System.Drawing.Size(21, 20);
            this.lblMaxB.TabIndex = 8;
            this.lblMaxB.Text = "B";
            // 
            // lblMaxA
            // 
            this.lblMaxA.AutoSize = true;
            this.lblMaxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxA.Location = new System.Drawing.Point(40, 0);
            this.lblMaxA.Name = "lblMaxA";
            this.lblMaxA.Size = new System.Drawing.Size(21, 20);
            this.lblMaxA.TabIndex = 8;
            this.lblMaxA.Text = "A";
            // 
            // lblNeedC
            // 
            this.lblNeedC.AutoSize = true;
            this.lblNeedC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeedC.Location = new System.Drawing.Point(130, 0);
            this.lblNeedC.Name = "lblNeedC";
            this.lblNeedC.Size = new System.Drawing.Size(21, 20);
            this.lblNeedC.TabIndex = 8;
            this.lblNeedC.Text = "C";
            // 
            // lblNeedB
            // 
            this.lblNeedB.AutoSize = true;
            this.lblNeedB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeedB.Location = new System.Drawing.Point(85, 0);
            this.lblNeedB.Name = "lblNeedB";
            this.lblNeedB.Size = new System.Drawing.Size(21, 20);
            this.lblNeedB.TabIndex = 8;
            this.lblNeedB.Text = "B";
            // 
            // lblNeedA
            // 
            this.lblNeedA.AutoSize = true;
            this.lblNeedA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeedA.Location = new System.Drawing.Point(40, 0);
            this.lblNeedA.Name = "lblNeedA";
            this.lblNeedA.Size = new System.Drawing.Size(21, 20);
            this.lblNeedA.TabIndex = 8;
            this.lblNeedA.Text = "A";
            // 
            // pnlAvai
            // 
            this.pnlAvai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAvai.Location = new System.Drawing.Point(0, 24);
            this.pnlAvai.Name = "pnlAvai";
            this.pnlAvai.Size = new System.Drawing.Size(152, 29);
            this.pnlAvai.TabIndex = 2;
            // 
            // pnlWork
            // 
            this.pnlWork.AutoScroll = true;
            this.pnlWork.BackColor = System.Drawing.Color.Red;
            this.pnlWork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlWork.Location = new System.Drawing.Point(691, 143);
            this.pnlWork.Name = "pnlWork";
            this.pnlWork.Size = new System.Drawing.Size(184, 262);
            this.pnlWork.TabIndex = 0;
            // 
            // lblWorkC
            // 
            this.lblWorkC.AutoSize = true;
            this.lblWorkC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkC.Location = new System.Drawing.Point(130, 0);
            this.lblWorkC.Name = "lblWorkC";
            this.lblWorkC.Size = new System.Drawing.Size(21, 20);
            this.lblWorkC.TabIndex = 8;
            this.lblWorkC.Text = "C";
            // 
            // lblWorkB
            // 
            this.lblWorkB.AutoSize = true;
            this.lblWorkB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkB.Location = new System.Drawing.Point(85, 0);
            this.lblWorkB.Name = "lblWorkB";
            this.lblWorkB.Size = new System.Drawing.Size(21, 20);
            this.lblWorkB.TabIndex = 8;
            this.lblWorkB.Text = "B";
            // 
            // lblWorkA
            // 
            this.lblWorkA.AutoSize = true;
            this.lblWorkA.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkA.Location = new System.Drawing.Point(40, 0);
            this.lblWorkA.Name = "lblWorkA";
            this.lblWorkA.Size = new System.Drawing.Size(21, 20);
            this.lblWorkA.TabIndex = 8;
            this.lblWorkA.Text = "A";
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackColor = System.Drawing.Color.DarkGray;
            this.btnCalculator.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.ForeColor = System.Drawing.Color.Black;
            this.btnCalculator.Location = new System.Drawing.Point(501, 371);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(184, 34);
            this.btnCalculator.TabIndex = 1;
            this.btnCalculator.Text = "Tính toán";
            this.btnCalculator.UseVisualStyleBackColor = false;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // pnlReq
            // 
            this.pnlReq.AutoScroll = true;
            this.pnlReq.BackColor = System.Drawing.Color.Blue;
            this.pnlReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlReq.Location = new System.Drawing.Point(186, 3);
            this.pnlReq.Name = "pnlReq";
            this.pnlReq.Size = new System.Drawing.Size(152, 29);
            this.pnlReq.TabIndex = 4;
            // 
            // cbbReq
            // 
            this.cbbReq.BackColor = System.Drawing.SystemColors.Control;
            this.cbbReq.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbReq.FormattingEnabled = true;
            this.cbbReq.Location = new System.Drawing.Point(20, 4);
            this.cbbReq.Name = "cbbReq";
            this.cbbReq.Size = new System.Drawing.Size(163, 26);
            this.cbbReq.TabIndex = 5;
            this.cbbReq.Text = "Request (Process)";
            // 
            // rabtnYes
            // 
            this.rabtnYes.AutoSize = true;
            this.rabtnYes.Checked = true;
            this.rabtnYes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabtnYes.Location = new System.Drawing.Point(23, 57);
            this.rabtnYes.Name = "rabtnYes";
            this.rabtnYes.Size = new System.Drawing.Size(165, 23);
            this.rabtnYes.TabIndex = 6;
            this.rabtnYes.TabStop = true;
            this.rabtnYes.Text = "Có nhận Request";
            this.rabtnYes.UseVisualStyleBackColor = true;
            this.rabtnYes.CheckedChanged += new System.EventHandler(this.rabtnYes_CheckedChanged);
            // 
            // rabtnNo
            // 
            this.rabtnNo.AutoSize = true;
            this.rabtnNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabtnNo.Location = new System.Drawing.Point(23, 85);
            this.rabtnNo.Name = "rabtnNo";
            this.rabtnNo.Size = new System.Drawing.Size(195, 23);
            this.rabtnNo.TabIndex = 6;
            this.rabtnNo.Text = "Không nhận Request";
            this.rabtnNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Allocation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Need";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(754, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Available";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(754, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Work";
            // 
            // lblAvaiA
            // 
            this.lblAvaiA.AutoSize = true;
            this.lblAvaiA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvaiA.Location = new System.Drawing.Point(25, 3);
            this.lblAvaiA.Name = "lblAvaiA";
            this.lblAvaiA.Size = new System.Drawing.Size(21, 20);
            this.lblAvaiA.TabIndex = 8;
            this.lblAvaiA.Text = "A";
            // 
            // lblAvaiB
            // 
            this.lblAvaiB.AutoSize = true;
            this.lblAvaiB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvaiB.Location = new System.Drawing.Point(64, 3);
            this.lblAvaiB.Name = "lblAvaiB";
            this.lblAvaiB.Size = new System.Drawing.Size(21, 20);
            this.lblAvaiB.TabIndex = 8;
            this.lblAvaiB.Text = "B";
            // 
            // lblAvaiC
            // 
            this.lblAvaiC.AutoSize = true;
            this.lblAvaiC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvaiC.Location = new System.Drawing.Point(103, 3);
            this.lblAvaiC.Name = "lblAvaiC";
            this.lblAvaiC.Size = new System.Drawing.Size(21, 20);
            this.lblAvaiC.TabIndex = 8;
            this.lblAvaiC.Text = "C";
            // 
            // pnlReqq
            // 
            this.pnlReqq.BackColor = System.Drawing.Color.Blue;
            this.pnlReqq.Controls.Add(this.cbbReq);
            this.pnlReqq.Controls.Add(this.pnlReq);
            this.pnlReqq.Location = new System.Drawing.Point(537, 79);
            this.pnlReqq.Name = "pnlReqq";
            this.pnlReqq.Size = new System.Drawing.Size(338, 35);
            this.pnlReqq.TabIndex = 9;
            // 
            // pnlAvaii
            // 
            this.pnlAvaii.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlAvaii.Controls.Add(this.pnlAvai);
            this.pnlAvaii.Controls.Add(this.lblAvaiC);
            this.pnlAvaii.Controls.Add(this.lblAvaiB);
            this.pnlAvaii.Controls.Add(this.lblAvaiA);
            this.pnlAvaii.Location = new System.Drawing.Point(723, 25);
            this.pnlAvaii.Name = "pnlAvaii";
            this.pnlAvaii.Size = new System.Drawing.Size(152, 54);
            this.pnlAvaii.TabIndex = 10;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(23, 385);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(76, 20);
            this.label26.TabIndex = 12;
            this.label26.Text = "Kết quả:";
            // 
            // cbbBgColor
            // 
            this.cbbBgColor.BackColor = System.Drawing.SystemColors.Control;
            this.cbbBgColor.FormattingEnabled = true;
            this.cbbBgColor.Items.AddRange(new object[] {
            "Cầu vồng",
            "Cam tươi"});
            this.cbbBgColor.Location = new System.Drawing.Point(0, 0);
            this.cbbBgColor.Name = "cbbBgColor";
            this.cbbBgColor.Size = new System.Drawing.Size(92, 21);
            this.cbbBgColor.TabIndex = 13;
            this.cbbBgColor.Text = "Chọn màu nền";
            this.cbbBgColor.SelectedIndexChanged += new System.EventHandler(this.cbbBgColor_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Số tiến trình";
            // 
            // nudProcess
            // 
            this.nudProcess.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudProcess.Location = new System.Drawing.Point(151, 29);
            this.nudProcess.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudProcess.Name = "nudProcess";
            this.nudProcess.Size = new System.Drawing.Size(37, 25);
            this.nudProcess.TabIndex = 14;
            this.nudProcess.ValueChanged += new System.EventHandler(this.nudProcess_ValueChanged);
            // 
            // pnlWorkk
            // 
            this.pnlWorkk.BackColor = System.Drawing.Color.Red;
            this.pnlWorkk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWorkk.Controls.Add(this.lblWorkB);
            this.pnlWorkk.Controls.Add(this.lblWorkA);
            this.pnlWorkk.Controls.Add(this.lblWorkC);
            this.pnlWorkk.Location = new System.Drawing.Point(691, 141);
            this.pnlWorkk.Name = "pnlWorkk";
            this.pnlWorkk.Size = new System.Drawing.Size(184, 22);
            this.pnlWorkk.TabIndex = 17;
            // 
            // pnlAllocc
            // 
            this.pnlAllocc.BackColor = System.Drawing.Color.Yellow;
            this.pnlAllocc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAllocc.Controls.Add(this.lblAllocC);
            this.pnlAllocc.Controls.Add(this.lblAllocB);
            this.pnlAllocc.Controls.Add(this.lblAllocA);
            this.pnlAllocc.Location = new System.Drawing.Point(23, 141);
            this.pnlAllocc.Name = "pnlAllocc";
            this.pnlAllocc.Size = new System.Drawing.Size(184, 22);
            this.pnlAllocc.TabIndex = 18;
            // 
            // pnlMaxx
            // 
            this.pnlMaxx.BackColor = System.Drawing.Color.Lime;
            this.pnlMaxx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMaxx.Controls.Add(this.lblMaxC);
            this.pnlMaxx.Controls.Add(this.lblMaxB);
            this.pnlMaxx.Controls.Add(this.lblMaxA);
            this.pnlMaxx.Location = new System.Drawing.Point(213, 141);
            this.pnlMaxx.Name = "pnlMaxx";
            this.pnlMaxx.Size = new System.Drawing.Size(184, 22);
            this.pnlMaxx.TabIndex = 18;
            // 
            // pnlNeedd
            // 
            this.pnlNeedd.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlNeedd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNeedd.Controls.Add(this.lblNeedC);
            this.pnlNeedd.Controls.Add(this.lblNeedB);
            this.pnlNeedd.Controls.Add(this.lblNeedA);
            this.pnlNeedd.Location = new System.Drawing.Point(403, 141);
            this.pnlNeedd.Name = "pnlNeedd";
            this.pnlNeedd.Size = new System.Drawing.Size(184, 22);
            this.pnlNeedd.TabIndex = 18;
            // 
            // pnlNeed
            // 
            this.pnlNeed.AutoScroll = true;
            this.pnlNeed.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlNeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlNeed.Location = new System.Drawing.Point(403, 143);
            this.pnlNeed.Name = "pnlNeed";
            this.pnlNeed.Size = new System.Drawing.Size(184, 222);
            this.pnlNeed.TabIndex = 0;
            // 
            // pnlMax
            // 
            this.pnlMax.AutoScroll = true;
            this.pnlMax.BackColor = System.Drawing.Color.Lime;
            this.pnlMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMax.Location = new System.Drawing.Point(213, 143);
            this.pnlMax.Name = "pnlMax";
            this.pnlMax.Size = new System.Drawing.Size(184, 222);
            this.pnlMax.TabIndex = 19;
            // 
            // fpnlResult
            // 
            this.fpnlResult.AutoScroll = true;
            this.fpnlResult.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlResult.Location = new System.Drawing.Point(23, 411);
            this.fpnlResult.Name = "fpnlResult";
            this.fpnlResult.Size = new System.Drawing.Size(128, 237);
            this.fpnlResult.TabIndex = 20;
            this.fpnlResult.WrapContents = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkGray;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(399, 371);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 34);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(193, 43);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(133, 25);
            this.btnRandom.TabIndex = 22;
            this.btnRandom.Text = "Tạo số ngẫu nhiên";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnRandomE
            // 
            this.btnRandomE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomE.Location = new System.Drawing.Point(193, 12);
            this.btnRandomE.Name = "btnRandomE";
            this.btnRandomE.Size = new System.Drawing.Size(133, 25);
            this.btnRandomE.TabIndex = 23;
            this.btnRandomE.Text = "Lấy dữ liệu test";
            this.btnRandomE.UseVisualStyleBackColor = true;
            this.btnRandomE.Click += new System.EventHandler(this.btnRandomE_Click);
            // 
            // chartResult
            // 
            this.chartResult.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Text;
            this.chartResult.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX.Title = "Tiến trình (P)";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.Interval = 2D;
            chartArea1.AxisY.IsInterlaced = true;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Giá trị";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.chartResult.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResult.Legends.Add(legend1);
            this.chartResult.Location = new System.Drawing.Point(159, 411);
            this.chartResult.Name = "chartResult";
            this.chartResult.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartResult.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.RoyalBlue,
        System.Drawing.Color.Firebrick,
        System.Drawing.Color.ForestGreen};
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            series1.Legend = "Legend1";
            series1.LegendText = "Giá trị A";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.LegendText = "Giá trị B";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series2";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.LegendText = "Giá trị C";
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Series3";
            this.chartResult.Series.Add(series1);
            this.chartResult.Series.Add(series2);
            this.chartResult.Series.Add(series3);
            this.chartResult.Size = new System.Drawing.Size(716, 270);
            this.chartResult.TabIndex = 24;
            this.chartResult.Text = "chart1";
            title1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Red;
            title1.Name = "Title1";
            title1.Text = "Biểu Đồ Xử Lý Các Tiến Trình Bộ Nhớ";
            this.chartResult.Titles.Add(title1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkGray;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(23, 651);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 30);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(893, 687);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRandomE);
            this.Controls.Add(this.chartResult);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.fpnlResult);
            this.Controls.Add(this.pnlWorkk);
            this.Controls.Add(this.pnlMaxx);
            this.Controls.Add(this.pnlNeedd);
            this.Controls.Add(this.pnlAllocc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudProcess);
            this.Controls.Add(this.cbbBgColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.pnlAvaii);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rabtnNo);
            this.Controls.Add(this.rabtnYes);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.pnlWork);
            this.Controls.Add(this.pnlNeed);
            this.Controls.Add(this.pnlAlloc);
            this.Controls.Add(this.pnlReqq);
            this.Controls.Add(this.pnlMax);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEADLOCK (Banker Algorithm)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlReqq.ResumeLayout(false);
            this.pnlAvaii.ResumeLayout(false);
            this.pnlAvaii.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProcess)).EndInit();
            this.pnlWorkk.ResumeLayout(false);
            this.pnlWorkk.PerformLayout();
            this.pnlAllocc.ResumeLayout(false);
            this.pnlAllocc.PerformLayout();
            this.pnlMaxx.ResumeLayout(false);
            this.pnlMaxx.PerformLayout();
            this.pnlNeedd.ResumeLayout(false);
            this.pnlNeedd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAlloc;
        private System.Windows.Forms.Panel pnlAvai;
        private System.Windows.Forms.Panel pnlWork;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Panel pnlReq;
        private System.Windows.Forms.ComboBox cbbReq;
        private System.Windows.Forms.RadioButton rabtnYes;
        private System.Windows.Forms.RadioButton rabtnNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAllocC;
        private System.Windows.Forms.Label lblAllocB;
        private System.Windows.Forms.Label lblAllocA;
        private System.Windows.Forms.Label lblMaxC;
        private System.Windows.Forms.Label lblMaxB;
        private System.Windows.Forms.Label lblMaxA;
        private System.Windows.Forms.Label lblNeedC;
        private System.Windows.Forms.Label lblNeedB;
        private System.Windows.Forms.Label lblNeedA;
        private System.Windows.Forms.Label lblWorkC;
        private System.Windows.Forms.Label lblWorkB;
        private System.Windows.Forms.Label lblWorkA;
        private System.Windows.Forms.Label lblAvaiA;
        private System.Windows.Forms.Label lblAvaiB;
        private System.Windows.Forms.Label lblAvaiC;
        private System.Windows.Forms.Panel pnlReqq;
        private System.Windows.Forms.Panel pnlAvaii;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cbbBgColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudProcess;
        private System.Windows.Forms.Panel pnlWorkk;
        private System.Windows.Forms.Panel pnlAllocc;
        private System.Windows.Forms.Panel pnlMaxx;
        private System.Windows.Forms.Panel pnlNeedd;
        private System.Windows.Forms.Panel pnlNeed;
        private System.Windows.Forms.Panel pnlMax;
        private System.Windows.Forms.FlowLayoutPanel fpnlResult;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnRandomE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private System.Windows.Forms.Button btnExit;
    }
}

