namespace WaveForm
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonStart = new Button();
            buttonStop = new Button();
            label1 = new Label();
            labelCurrentValue = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label3 = new Label();
            labelAverage = new Label();
            label5 = new Label();
            labelMax = new Label();
            label7 = new Label();
            labelMin = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            numericThreshold = new NumericUpDown();
            label9 = new Label();
            label10 = new Label();
            labelAlertStatus = new Label();
            buttonCheckReset = new Button();
            groupBox2 = new GroupBox();
            numericInterval = new NumericUpDown();
            label12 = new Label();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericThreshold).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericInterval).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            buttonStart.Location = new Point(39, 22);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(116, 46);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += StartButton_Click;
            // 
            // buttonStop
            // 
            buttonStop.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            buttonStop.Location = new Point(161, 22);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(116, 46);
            buttonStop.TabIndex = 0;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += StopButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 5, 0, 5);
            label1.Size = new Size(61, 33);
            label1.TabIndex = 2;
            label1.Text = "現在値";
            // 
            // labelCurrentValue
            // 
            labelCurrentValue.AutoSize = true;
            labelCurrentValue.Location = new Point(78, 0);
            labelCurrentValue.Name = "labelCurrentValue";
            labelCurrentValue.Padding = new Padding(0, 5, 0, 5);
            labelCurrentValue.Size = new Size(19, 33);
            labelCurrentValue.TabIndex = 3;
            labelCurrentValue.Text = "0";
            labelCurrentValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(39, 168);
            chart1.Name = "chart1";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(724, 278);
            chart1.TabIndex = 4;
            chart1.Text = "chart1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 33);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 5, 0, 5);
            label3.Size = new Size(61, 33);
            label3.TabIndex = 5;
            label3.Text = "平均値";
            // 
            // labelAverage
            // 
            labelAverage.AutoSize = true;
            labelAverage.Location = new Point(78, 33);
            labelAverage.Name = "labelAverage";
            labelAverage.Padding = new Padding(0, 5, 0, 5);
            labelAverage.Size = new Size(32, 33);
            labelAverage.TabIndex = 6;
            labelAverage.Text = "0.0";
            labelAverage.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 5, 0, 5);
            label5.Size = new Size(61, 33);
            label5.TabIndex = 7;
            label5.Text = "最大値";
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.Location = new Point(228, 0);
            labelMax.Name = "labelMax";
            labelMax.Padding = new Padding(0, 5, 0, 5);
            labelMax.Size = new Size(19, 33);
            labelMax.TabIndex = 8;
            labelMax.Text = "0";
            labelMax.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(153, 33);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 5, 0, 5);
            label7.Size = new Size(61, 33);
            label7.TabIndex = 9;
            label7.Text = "最小値";
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Location = new Point(228, 33);
            labelMin.Name = "labelMin";
            labelMin.Padding = new Padding(0, 5, 0, 5);
            labelMin.Size = new Size(19, 33);
            labelMin.TabIndex = 10;
            labelMin.Text = "0";
            labelMin.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(labelCurrentValue, 1, 0);
            tableLayoutPanel1.Controls.Add(labelAverage, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Controls.Add(labelMax, 3, 0);
            tableLayoutPanel1.Controls.Add(label7, 2, 1);
            tableLayoutPanel1.Controls.Add(labelMin, 3, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Location = new Point(16, 48);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(301, 67);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            groupBox1.Location = new Point(440, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 140);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "モニタ値（統計値は直近20件まで対象）";
            // 
            // numericThreshold
            // 
            numericThreshold.Location = new Point(6, 49);
            numericThreshold.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericThreshold.Name = "numericThreshold";
            numericThreshold.Size = new Size(99, 30);
            numericThreshold.TabIndex = 13;
            numericThreshold.TextAlign = HorizontalAlignment.Right;
            numericThreshold.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label9.Location = new Point(6, 26);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 14;
            label9.Text = "しきい値";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label10.Location = new Point(6, 36);
            label10.Name = "label10";
            label10.Size = new Size(61, 23);
            label10.TabIndex = 15;
            label10.Text = "状態：";
            // 
            // labelAlertStatus
            // 
            labelAlertStatus.AutoSize = true;
            labelAlertStatus.BackColor = Color.GreenYellow;
            labelAlertStatus.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            labelAlertStatus.Location = new Point(73, 36);
            labelAlertStatus.Name = "labelAlertStatus";
            labelAlertStatus.Size = new Size(44, 23);
            labelAlertStatus.TabIndex = 16;
            labelAlertStatus.Text = "正常";
            // 
            // buttonCheckReset
            // 
            buttonCheckReset.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            buttonCheckReset.Location = new Point(130, 30);
            buttonCheckReset.Name = "buttonCheckReset";
            buttonCheckReset.Size = new Size(94, 29);
            buttonCheckReset.TabIndex = 17;
            buttonCheckReset.Text = "判定リセット";
            buttonCheckReset.UseVisualStyleBackColor = true;
            buttonCheckReset.Click += CheckResetButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericInterval);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(numericThreshold);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            groupBox2.Location = new Point(286, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(144, 140);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "設定";
            // 
            // numericInterval
            // 
            numericInterval.Location = new Point(6, 104);
            numericInterval.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericInterval.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericInterval.Name = "numericInterval";
            numericInterval.Size = new Size(99, 30);
            numericInterval.TabIndex = 16;
            numericInterval.TextAlign = HorizontalAlignment.Right;
            numericInterval.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numericInterval.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label12.Location = new Point(6, 82);
            label12.Name = "label12";
            label12.Size = new Size(98, 20);
            label12.TabIndex = 15;
            label12.Text = "更新間隔[ms]";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(buttonCheckReset);
            groupBox3.Controls.Add(labelAlertStatus);
            groupBox3.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            groupBox3.Location = new Point(39, 84);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(238, 78);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "しきい値判定";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(chart1);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericThreshold).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericInterval).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStart;
        private Button buttonStop;
        private Label label1;
        private Label labelCurrentValue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label3;
        private Label labelAverage;
        private Label label5;
        private Label labelMax;
        private Label label7;
        private Label labelMin;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private NumericUpDown numericThreshold;
        private Label label9;
        private Label label10;
        private Label labelAlertStatus;
        private Button buttonCheckReset;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private NumericUpDown numericInterval;
        private Label label12;
    }
}
