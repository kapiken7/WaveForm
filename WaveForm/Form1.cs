using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WaveForm
{
    public partial class MainForm : Form
    {
        private readonly DataController controller;
        private Series dataseries = null!;

        public MainForm()
        {
            InitializeComponent();

            InitializeChart();

            controller = new DataController();

            // データ生成完了通知用デリゲート登録
            controller.DataGenerated = (int value) =>
            {
                label2.Text = value.ToString();
            };

            // チャート更新用デリゲート登録
            controller.ChartUpdate = (List<(DateTime time, int value)> values) =>
            {
                // チャートのクリア
                dataseries.Points.Clear();

                // グラフにデータ追加
                foreach ((DateTime time, int value) value in values)
                {
                    dataseries.Points.AddXY(value.time, value.value);
                }
            };

            // データ解析完了通知用デリゲート登録
            controller.DataAnalyzed = (double avarage, int max, int min) =>
            {
                label4.Text = avarage.ToString();
                label6.Text = max.ToString();
                label8.Text = min.ToString();
            };

            // アラート通知用デリゲート登録
            controller.DataAlerted = () =>
            {
                // UIにアラート表示
                label11.Text = "異常";
                label11.BackColor = System.Drawing.Color.Red;
            };

        }

        // Chartの初期化
        private void InitializeChart()
        {
            // グラフのクリア
            chart1.Series.Clear();
            // グラフの追加
            dataseries = chart1.Series.Add("Value");
            // グラフの種類を折れ線グラフに指定
            dataseries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            // グラフのX軸の型をDateTimeに設定
            dataseries.XValueType = ChartValueType.DateTime;
            // 線の太さを5に設定
            dataseries.BorderWidth = 5;

            // ChartAreaの取得
            ChartArea area = chart1.ChartAreas[0];

            // X軸のラベル書式を設定
            area.AxisX.LabelStyle.Format = "HH:mm:ss";

            // X軸の間隔を1秒に設定
            area.AxisX.IntervalType = DateTimeIntervalType.Seconds;
            area.AxisX.Interval = 1;
        }

        // Startボタン押下
        private void StartButton_Click(object sender, EventArgs e)
        {
            controller.Start();
        }

        // Stopボタン押下
        private void StopButton_Click(object sender, EventArgs e)
        {
            controller.Stop();
        }

        // NumericUpDownの値変更
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // UIから閾値取得
            int threshold = (int)numericUpDown1.Value;

            // 閾値設定
            controller.SetThreshold(threshold);
        }

        // CheckResetボタン押下
        private void CheckResetButton_Click(object sender, EventArgs e)
        {
            label11.Text = "正常";
            label11.BackColor = System.Drawing.Color.GreenYellow;
        }
    }
}
