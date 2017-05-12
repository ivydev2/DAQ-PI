namespace AnalogIn_toStripchart_SW_Timed
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
            this.Label2 = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.txtADValue = new System.Windows.Forms.TextBox();
            this.cbRate = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Button6 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.cmboAInRange = new System.Windows.Forms.ComboBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.nudAInChannel = new System.Windows.Forms.NumericUpDown();
            this.lblAIMode = new System.Windows.Forms.Label();
            this.tmrAnalogIn = new System.Windows.Forms.Timer(this.components);
            this.Label4 = new System.Windows.Forms.Label();
            this.stripChart1 = new BERGtools.StripChart();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.nudAInChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(271, 134);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(143, 20);
            this.Label2.TabIndex = 207;
            this.Label2.Text = "Measured Voltage:";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.Location = new System.Drawing.Point(533, 623);
            this.btnStartStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(294, 136);
            this.btnStartStop.TabIndex = 204;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // txtADValue
            // 
            this.txtADValue.Location = new System.Drawing.Point(418, 130);
            this.txtADValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtADValue.Name = "txtADValue";
            this.txtADValue.Size = new System.Drawing.Size(133, 26);
            this.txtADValue.TabIndex = 205;
            // 
            // cbRate
            // 
            this.cbRate.Location = new System.Drawing.Point(758, 74);
            this.cbRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRate.Name = "cbRate";
            this.cbRate.Size = new System.Drawing.Size(79, 28);
            this.cbRate.TabIndex = 203;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(620, 80);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(134, 20);
            this.Label5.TabIndex = 202;
            this.Label5.Text = "Samples/Second:";
            // 
            // Button6
            // 
            this.Button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.Location = new System.Drawing.Point(121, 833);
            this.Button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(132, 42);
            this.Button6.TabIndex = 196;
            this.Button6.Text = "End";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(358, 582);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(66, 22);
            this.Label3.TabIndex = 200;
            this.Label3.Text = "Status:";
            // 
            // cmboAInRange
            // 
            this.cmboAInRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboAInRange.FormattingEnabled = true;
            this.cmboAInRange.Location = new System.Drawing.Point(362, 79);
            this.cmboAInRange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmboAInRange.Name = "cmboAInRange";
            this.cmboAInRange.Size = new System.Drawing.Size(174, 30);
            this.cmboAInRange.TabIndex = 199;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label23.Location = new System.Drawing.Point(31, 79);
            this.Label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(82, 22);
            this.Label23.TabIndex = 195;
            this.Label23.Text = "Channel:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(288, 79);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(68, 22);
            this.Label1.TabIndex = 198;
            this.Label1.Text = "Range:";
            // 
            // nudAInChannel
            // 
            this.nudAInChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAInChannel.Location = new System.Drawing.Point(115, 74);
            this.nudAInChannel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudAInChannel.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudAInChannel.Name = "nudAInChannel";
            this.nudAInChannel.Size = new System.Drawing.Size(69, 28);
            this.nudAInChannel.TabIndex = 197;
            // 
            // lblAIMode
            // 
            this.lblAIMode.AutoSize = true;
            this.lblAIMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAIMode.Location = new System.Drawing.Point(433, 582);
            this.lblAIMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAIMode.Name = "lblAIMode";
            this.lblAIMode.Size = new System.Drawing.Size(38, 22);
            this.lblAIMode.TabIndex = 194;
            this.lblAIMode.Text = "Idle";
            // 
            // tmrAnalogIn
            // 
            this.tmrAnalogIn.Tick += new System.EventHandler(this.tmrAnalogIn_Tick);
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(13, 9);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(838, 65);
            this.Label4.TabIndex = 208;
            this.Label4.Text = "DAQ Application\r\nMCC1408FS";
            // 
            // stripChart1
            // 
            this.stripChart1.AutoScale = false;
            this.stripChart1.BackgroundColor = System.Drawing.Color.Lavender;
            this.stripChart1.FontColor = System.Drawing.Color.DarkGreen;
            this.stripChart1.ForeColor = System.Drawing.Color.Coral;
            this.stripChart1.Location = new System.Drawing.Point(65, 170);
            this.stripChart1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.stripChart1.Name = "stripChart1";
            this.stripChart1.ScaleColor = System.Drawing.Color.Lime;
            this.stripChart1.Size = new System.Drawing.Size(462, 394);
            this.stripChart1.TabIndex = 209;
            this.stripChart1.TimeInterval = 200D;
            this.stripChart1.TracePen = System.Drawing.Color.SkyBlue;
            this.stripChart1.XTicks = 3;
            this.stripChart1.YMaximum = 10D;
            this.stripChart1.YMinimum = -10D;
            this.stripChart1.YTicks = 10;
            this.stripChart1.Load += new System.EventHandler(this.stripChart1_Load);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 1051);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 268;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 1071);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 269;
            this.label6.Text = "label6";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(60, 623);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 24);
            this.radioButton1.TabIndex = 270;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "TC-1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(60, 661);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 24);
            this.radioButton2.TabIndex = 271;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "TC-2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(60, 698);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(68, 24);
            this.radioButton3.TabIndex = 272;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "TC-3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(60, 733);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(68, 24);
            this.radioButton4.TabIndex = 273;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "TC-4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(271, 623);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(68, 24);
            this.radioButton5.TabIndex = 274;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "TC-5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(271, 660);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(68, 24);
            this.radioButton6.TabIndex = 275;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "TC-6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(271, 697);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(68, 24);
            this.radioButton7.TabIndex = 276;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "TC-7";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(271, 735);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(68, 24);
            this.radioButton8.TabIndex = 277;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "TC-8";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(317, 824);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(510, 69);
            this.trackBar1.TabIndex = 279;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(319, 979);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(518, 69);
            this.trackBar2.TabIndex = 280;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 822);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 68);
            this.button2.TabIndex = 281;
            this.button2.Text = "ON";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(160, 822);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 68);
            this.button3.TabIndex = 282;
            this.button3.Text = "Off";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 776);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 29);
            this.label9.TabIndex = 284;
            this.label9.Text = "Pump Control";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 801);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 285;
            this.label10.Text = "Pump Speed";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(313, 939);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 20);
            this.label13.TabIndex = 288;
            this.label13.Text = "Valve % Open";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(39, 930);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 29);
            this.label14.TabIndex = 287;
            this.label14.Text = "Gas Flow Control";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(160, 979);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 69);
            this.button4.TabIndex = 291;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(48, 979);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 69);
            this.button5.TabIndex = 290;
            this.button5.Text = "Open";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 623);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 26);
            this.textBox1.TabIndex = 292;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 659);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 26);
            this.textBox2.TabIndex = 293;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 695);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(103, 26);
            this.textBox3.TabIndex = 294;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(146, 731);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(103, 26);
            this.textBox4.TabIndex = 295;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(362, 623);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(103, 26);
            this.textBox5.TabIndex = 296;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(362, 661);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(103, 26);
            this.textBox6.TabIndex = 297;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(362, 695);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(103, 26);
            this.textBox7.TabIndex = 298;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(362, 731);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(103, 26);
            this.textBox8.TabIndex = 299;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 300;
            this.label8.Text = "Sensors";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(636, 170);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(615, 400);
            this.chart1.TabIndex = 301;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 1148);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.stripChart1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.txtADValue);
            this.Controls.Add(this.cbRate);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.cmboAInRange);
            this.Controls.Add(this.Label23);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.nudAInChannel);
            this.Controls.Add(this.lblAIMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Pi-Innovations DAQ Application R1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAInChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.TextBox txtADValue;
        private System.Windows.Forms.ComboBox cbRate;
        private System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cmboAInRange;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.NumericUpDown nudAInChannel;
        internal System.Windows.Forms.Label lblAIMode;
        internal System.Windows.Forms.Timer tmrAnalogIn;
        internal System.Windows.Forms.Label Label4;
        private BERGtools.StripChart stripChart1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

