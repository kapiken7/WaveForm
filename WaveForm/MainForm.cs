using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WaveForm
{
    public partial class MainForm : Form
    {
        private readonly DataController controller;
        private Series dataSeries = null!;

        public MainForm()
        {
            InitializeComponent();

            InitializeChart();

            controller = new DataController();

            // 閾値設定の読み込み
            numericThreshold.Value = Properties.Settings.Default.Threshold;
            controller.SetThreshold((int)numericThreshold.Value);

            // インターバル設定の読み込み
            numericInterval.Value = Properties.Settings.Default.TimeInterval;
            controller.SetInterval((int)numericInterval.Value);

            // データ生成完了通知用デリゲート登録
            controller.DataGenerated = (int value) =>
                {
                    labelCurrentValue.Text = value.ToString();
                };

            // チャート更新用デリゲート登録
            controller.ChartUpdate = (List<(DateTime time, int value)> values) =>
            {
                // チャートのクリア
                dataSeries.Points.Clear();

                // グラフにデータ追加
                foreach ((DateTime time, int value) value in values)
                {
                    dataSeries.Points.AddXY(value.time, value.value);
                }
            };

            // データ解析完了通知用デリゲート登録
            controller.DataAnalyzed = (double avarage, int max, int min) =>
            {
                labelAverage.Text = avarage.ToString();
                labelMax.Text = max.ToString();
                labelMin.Text = min.ToString();
            };

            // アラート通知用デリゲート登録
            controller.DataAlerted = () =>
            {
                // UIにアラート表示
                labelAlertStatus.Text = "異常";
                labelAlertStatus.BackColor = System.Drawing.Color.Red;
            };

        }

        // Chartの初期化
        private void InitializeChart()
        {
            // グラフのクリア
            chart1.Series.Clear();
            // グラフの追加
            dataSeries = chart1.Series.Add("Value");
            // グラフの種類を折れ線グラフに指定
            dataSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            // グラフのX軸の型をDateTimeに設定
            dataSeries.XValueType = ChartValueType.DateTime;
            // 線の太さを5に設定
            dataSeries.BorderWidth = 5;

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

        // 閾値変更時
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // 閾値設定
            controller.SetThreshold((int)numericThreshold.Value);
        }

        // インターバル変更時
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            // インターバル設定
            controller.SetInterval((int)numericInterval.Value);
        }

        // CheckResetボタン押下
        private void CheckResetButton_Click(object sender, EventArgs e)
        {
            labelAlertStatus.Text = "正常";
            labelAlertStatus.BackColor = System.Drawing.Color.GreenYellow;
        }

        // フォームクローズ時
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // インターバル設定の保存
            Properties.Settings.Default.TimeInterval = (int)numericInterval.Value;
            // 閾値設定の保存
            Properties.Settings.Default.Threshold = (int)numericThreshold.Value;
            // 設定の保存
            Properties.Settings.Default.Save();
        }
    }
}
