namespace Mindwave.UI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.comboCom = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStopRead = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBaudrate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.WavesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboExperiment = new System.Windows.Forms.ComboBox();
            this.btnStopExperiment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboAge = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStartExperiment = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.colorsTab = new System.Windows.Forms.TabPage();
            this.PanelColor = new System.Windows.Forms.Panel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.counterLabel = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.VerticalPictureBox = new System.Windows.Forms.PictureBox();
            this.HorizontalPictureBox = new System.Windows.Forms.PictureBox();
            this.lblSignal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.ExperimentTime = new System.Windows.Forms.Timer(this.components);
            this.AttentionProgress = new System.Windows.Forms.ProgressBar();
            this.MeditationProgress = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AttentionLabel = new System.Windows.Forms.Label();
            this.MeditationLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WavesChart)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.colorsTab.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(7, 128);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(318, 28);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(7, 163);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(318, 28);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // comboCom
            // 
            this.comboCom.BackColor = System.Drawing.SystemColors.Window;
            this.comboCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCom.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.comboCom.Location = new System.Drawing.Point(113, 37);
            this.comboCom.Margin = new System.Windows.Forms.Padding(4);
            this.comboCom.Name = "comboCom";
            this.comboCom.Size = new System.Drawing.Size(212, 24);
            this.comboCom.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 27);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1220, 772);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnRead);
            this.tabPage1.Controls.Add(this.btnClearLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1212, 743);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Device";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStopRead);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboCom);
            this.groupBox1.Controls.Add(this.comboBaudrate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 242);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mindwave Headset";
            // 
            // btnStopRead
            // 
            this.btnStopRead.Enabled = false;
            this.btnStopRead.Location = new System.Drawing.Point(7, 198);
            this.btnStopRead.Name = "btnStopRead";
            this.btnStopRead.Size = new System.Drawing.Size(316, 28);
            this.btnStopRead.TabIndex = 13;
            this.btnStopRead.Text = "Stop";
            this.btnStopRead.UseVisualStyleBackColor = true;
            this.btnStopRead.Click += new System.EventHandler(this.btnStopRead_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baudrate";
            // 
            // comboBaudrate
            // 
            this.comboBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBaudrate.FormattingEnabled = true;
            this.comboBaudrate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "57600",
            "115200"});
            this.comboBaudrate.Location = new System.Drawing.Point(113, 70);
            this.comboBaudrate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBaudrate.Name = "comboBaudrate";
            this.comboBaudrate.Size = new System.Drawing.Size(212, 24);
            this.comboBaudrate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM Port";
            // 
            // btnRead
            // 
            this.btnRead.Enabled = false;
            this.btnRead.Location = new System.Drawing.Point(44, 656);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(252, 28);
            this.btnRead.TabIndex = 9;
            this.btnRead.Text = "Read Data";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(44, 692);
            this.btnClearLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(252, 28);
            this.btnClearLog.TabIndex = 6;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.WavesChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1212, 743);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Waves";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // WavesChart
            // 
            chartArea1.Name = "ChartArea1";
            this.WavesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.WavesChart.Legends.Add(legend1);
            this.WavesChart.Location = new System.Drawing.Point(8, 7);
            this.WavesChart.Margin = new System.Windows.Forms.Padding(4);
            this.WavesChart.Name = "WavesChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.WavesChart.Series.Add(series1);
            this.WavesChart.Size = new System.Drawing.Size(1193, 590);
            this.WavesChart.TabIndex = 0;
            this.WavesChart.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1212, 743);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Experiment";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboExperiment);
            this.groupBox2.Controls.Add(this.btnStopExperiment);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboAge);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnStartExperiment);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(7, 555);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1192, 179);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Session";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Experiment";
            // 
            // comboExperiment
            // 
            this.comboExperiment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExperiment.FormattingEnabled = true;
            this.comboExperiment.Items.AddRange(new object[] {
            "Colors",
            "Counting",
            "Movements"});
            this.comboExperiment.Location = new System.Drawing.Point(108, 23);
            this.comboExperiment.Name = "comboExperiment";
            this.comboExperiment.Size = new System.Drawing.Size(230, 24);
            this.comboExperiment.TabIndex = 17;
            // 
            // btnStopExperiment
            // 
            this.btnStopExperiment.Enabled = false;
            this.btnStopExperiment.Location = new System.Drawing.Point(108, 141);
            this.btnStopExperiment.Name = "btnStopExperiment";
            this.btnStopExperiment.Size = new System.Drawing.Size(230, 27);
            this.btnStopExperiment.TabIndex = 16;
            this.btnStopExperiment.Text = "Stop";
            this.btnStopExperiment.UseVisualStyleBackColor = true;
            this.btnStopExperiment.Click += new System.EventHandler(this.BtnStopExperiment_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Age";
            // 
            // comboAge
            // 
            this.comboAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAge.FormattingEnabled = true;
            this.comboAge.Items.AddRange(new object[] {
            "None",
            "18 - 24",
            "25 - 29",
            "30 - 34",
            "35 - 39",
            "40 - 44",
            "45 - 49",
            "50 - 54",
            "55 - 59",
            "60 - 64"});
            this.comboAge.Location = new System.Drawing.Point(444, 60);
            this.comboAge.Name = "comboAge";
            this.comboAge.Size = new System.Drawing.Size(156, 24);
            this.comboAge.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Full Name";
            // 
            // btnStartExperiment
            // 
            this.btnStartExperiment.Location = new System.Drawing.Point(108, 108);
            this.btnStartExperiment.Name = "btnStartExperiment";
            this.btnStartExperiment.Size = new System.Drawing.Size(230, 27);
            this.btnStartExperiment.TabIndex = 1;
            this.btnStartExperiment.Text = "Start";
            this.btnStartExperiment.UseVisualStyleBackColor = true;
            this.btnStartExperiment.Click += new System.EventHandler(this.btnStartExperiment_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 22);
            this.txtName.TabIndex = 13;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.colorsTab);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Enabled = false;
            this.tabControl2.Location = new System.Drawing.Point(3, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1200, 543);
            this.tabControl2.TabIndex = 0;
            // 
            // colorsTab
            // 
            this.colorsTab.Controls.Add(this.PanelColor);
            this.colorsTab.Location = new System.Drawing.Point(4, 25);
            this.colorsTab.Name = "colorsTab";
            this.colorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.colorsTab.Size = new System.Drawing.Size(1192, 514);
            this.colorsTab.TabIndex = 0;
            this.colorsTab.Text = "Colors Experiment";
            this.colorsTab.UseVisualStyleBackColor = true;
            // 
            // PanelColor
            // 
            this.PanelColor.Location = new System.Drawing.Point(6, 6);
            this.PanelColor.Name = "PanelColor";
            this.PanelColor.Size = new System.Drawing.Size(1180, 502);
            this.PanelColor.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.counterLabel);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1192, 514);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Counting Backwards";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLabel.Location = new System.Drawing.Point(448, 168);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(238, 170);
            this.counterLabel.TabIndex = 0;
            this.counterLabel.Text = "00";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.VerticalPictureBox);
            this.tabPage4.Controls.Add(this.HorizontalPictureBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1192, 514);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Movements";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // VerticalPictureBox
            // 
            this.VerticalPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("VerticalPictureBox.Image")));
            this.VerticalPictureBox.Location = new System.Drawing.Point(505, 105);
            this.VerticalPictureBox.Name = "VerticalPictureBox";
            this.VerticalPictureBox.Size = new System.Drawing.Size(129, 310);
            this.VerticalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VerticalPictureBox.TabIndex = 1;
            this.VerticalPictureBox.TabStop = false;
            this.VerticalPictureBox.Visible = false;
            // 
            // HorizontalPictureBox
            // 
            this.HorizontalPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("HorizontalPictureBox.Image")));
            this.HorizontalPictureBox.Location = new System.Drawing.Point(407, 176);
            this.HorizontalPictureBox.Name = "HorizontalPictureBox";
            this.HorizontalPictureBox.Size = new System.Drawing.Size(345, 162);
            this.HorizontalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HorizontalPictureBox.TabIndex = 0;
            this.HorizontalPictureBox.TabStop = false;
            // 
            // lblSignal
            // 
            this.lblSignal.AutoSize = true;
            this.lblSignal.BackColor = System.Drawing.Color.Red;
            this.lblSignal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSignal.Location = new System.Drawing.Point(109, 909);
            this.lblSignal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignal.Name = "lblSignal";
            this.lblSignal.Size = new System.Drawing.Size(33, 17);
            this.lblSignal.TabIndex = 8;
            this.lblSignal.Text = "Bad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 909);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Signal";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(21, 807);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(1211, 88);
            this.txtLog.TabIndex = 4;
            // 
            // ExperimentTime
            // 
            this.ExperimentTime.Interval = 2000;
            this.ExperimentTime.Tick += new System.EventHandler(this.ExperimentTime_Tick);
            // 
            // AttentionProgress
            // 
            this.AttentionProgress.Location = new System.Drawing.Point(358, 903);
            this.AttentionProgress.Name = "AttentionProgress";
            this.AttentionProgress.Size = new System.Drawing.Size(189, 23);
            this.AttentionProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.AttentionProgress.TabIndex = 9;
            // 
            // MeditationProgress
            // 
            this.MeditationProgress.Location = new System.Drawing.Point(833, 903);
            this.MeditationProgress.Name = "MeditationProgress";
            this.MeditationProgress.Size = new System.Drawing.Size(189, 23);
            this.MeditationProgress.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 909);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Attention";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(741, 909);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Meditation";
            // 
            // AttentionLabel
            // 
            this.AttentionLabel.AutoSize = true;
            this.AttentionLabel.Location = new System.Drawing.Point(553, 908);
            this.AttentionLabel.Name = "AttentionLabel";
            this.AttentionLabel.Size = new System.Drawing.Size(0, 17);
            this.AttentionLabel.TabIndex = 13;
            // 
            // MeditationLabel
            // 
            this.MeditationLabel.AutoSize = true;
            this.MeditationLabel.Location = new System.Drawing.Point(1028, 908);
            this.MeditationLabel.Name = "MeditationLabel";
            this.MeditationLabel.Size = new System.Drawing.Size(0, 17);
            this.MeditationLabel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 938);
            this.Controls.Add(this.MeditationLabel);
            this.Controls.Add(this.AttentionLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MeditationProgress);
            this.Controls.Add(this.AttentionProgress);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lblSignal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mindwave";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WavesChart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.colorsTab.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VerticalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.Button btnDisconnect;
    private System.Windows.Forms.ComboBox comboCom;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.ComboBox comboBaudrate;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TextBox txtLog;
    private System.Windows.Forms.Button btnClearLog;
    private System.Windows.Forms.Label lblSignal;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DataVisualization.Charting.Chart WavesChart;
    private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStopRead;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnStartExperiment;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage colorsTab;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel PanelColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboAge;
        private System.Windows.Forms.Button btnStopExperiment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboExperiment;
        private System.Windows.Forms.Timer ExperimentTime;
        private System.Windows.Forms.ProgressBar AttentionProgress;
        private System.Windows.Forms.ProgressBar MeditationProgress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label AttentionLabel;
        private System.Windows.Forms.Label MeditationLabel;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox HorizontalPictureBox;
        private System.Windows.Forms.PictureBox VerticalPictureBox;
    }
}

