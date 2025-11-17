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
            StartButton = new Button();
            StopButton = new Button();
            label1 = new Label();
            label2 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            StartButton.Location = new Point(39, 21);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(141, 40);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // StopButton
            // 
            StopButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            StopButton.Location = new Point(197, 21);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(141, 40);
            StopButton.TabIndex = 1;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 5, 0, 5);
            label1.Size = new Size(54, 30);
            label1.TabIndex = 2;
            label1.Text = "現在値";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 5, 0, 5);
            label2.Size = new Size(17, 30);
            label2.TabIndex = 3;
            label2.Text = "0";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(39, 120);
            chart1.Name = "chart1";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(724, 326);
            chart1.TabIndex = 4;
            chart1.Text = "chart1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 33);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 5, 0, 5);
            label3.Size = new Size(54, 30);
            label3.TabIndex = 5;
            label3.Text = "平均値";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 33);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 5, 0, 5);
            label4.Size = new Size(28, 30);
            label4.TabIndex = 6;
            label4.Text = "0.0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(141, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 5, 0, 5);
            label5.Size = new Size(54, 30);
            label5.TabIndex = 7;
            label5.Text = "最大値";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(210, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 5, 0, 5);
            label6.Size = new Size(17, 30);
            label6.TabIndex = 8;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(141, 33);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 5, 0, 5);
            label7.Size = new Size(54, 30);
            label7.TabIndex = 9;
            label7.Text = "最小値";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(210, 33);
            label8.Name = "label8";
            label8.Padding = new Padding(0, 5, 0, 5);
            label8.Size = new Size(17, 30);
            label8.TabIndex = 10;
            label8.Text = "0";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Controls.Add(label6, 3, 0);
            tableLayoutPanel1.Controls.Add(label7, 2, 1);
            tableLayoutPanel1.Controls.Add(label8, 3, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Location = new Point(40, 18);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(278, 67);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            groupBox1.Location = new Point(410, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 91);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "モニタ値（統計値は直近20件）";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(111, 82);
            numericUpDown1.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(99, 27);
            numericUpDown1.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label9.Location = new Point(39, 82);
            label9.Name = "label9";
            label9.Size = new Size(66, 23);
            label9.TabIndex = 14;
            label9.Text = "しきい値";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label10.Location = new Point(221, 82);
            label10.Name = "label10";
            label10.Size = new Size(117, 23);
            label10.TabIndex = 15;
            label10.Text = "しきい値判定：";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(192, 255, 192);
            label11.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label11.Location = new Point(344, 82);
            label11.Name = "label11";
            label11.Size = new Size(44, 23);
            label11.TabIndex = 16;
            label11.Text = "正常";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(numericUpDown1);
            Controls.Add(chart1);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Button StopButton;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown1;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}
