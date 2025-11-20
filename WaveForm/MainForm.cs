using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WaveForm
{
    public partial class MainForm : Form
    {
        // DataControllerクラス
        private readonly DataController controller;
        // チャート用データシリーズ
        private Series dataSeries = null!;
        // エラーメッセージ表示中フラグ
        private bool isShowingError;

        public MainForm()
        {
            InitializeComponent();

            InitializeChart();

            isShowingError = false;

            controller = new DataController();

            // しきい値設定の読み込み
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

                // X軸の範囲設定（最新20秒分表示）
                chartMonitor.ChartAreas[0].AxisX.Maximum = values[values.Count-1].time.ToOADate();
                chartMonitor.ChartAreas[0].AxisX.Minimum = chartMonitor.ChartAreas[0].AxisX.Maximum - TimeSpan.FromSeconds(20).TotalDays;

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
                // リセットボタン有効化
                buttonCheckReset.Enabled = true;
                buttonCheckReset.BackColor = System.Drawing.Color.White;
            };

            // ログ書き込みエラー通知用デリゲート登録
            controller.LoggerErrorOccurred = (string message) =>
            {
                //// 既にエラーメッセージ表示中なら何もしない
                //if (isShowingError)
                //{
                //    return;
                //}

                //// エラーメッセージ表示中フラグを立てる
                //isShowingError = true;

                //MessageBox.Show(message, "ログ書き込みエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //// エラーメッセージ表示中フラグを下ろす
                //isShowingError = false;

                if (panelError.Visible)
                {
                    // 既にエラーパネルが表示されている場合は何もしない
                    return;
                }

                // エラーパネル表示
                labelErrorText.Text = message;
                panelError.Visible = true;

                // 3秒後にエラーパネルを非表示にするタイマー
                var timer = new System.Windows.Forms.Timer();
                timer.Interval = 3000;
                timer.Tick += (s, ev) =>
                {
                    panelError.Visible = false;
                    timer.Stop();
                };
                timer.Start();
            };
        }

        // Chartの初期化
        private void InitializeChart()
        {
            // グラフのクリア
            chartMonitor.Series.Clear();
            // 凡例のタイトルを設定
            chartMonitor.Legends[0].Font = new Font("Yu Gothic UI", 10, FontStyle.Bold);
            // グラフの追加
            dataSeries = chartMonitor.Series.Add("Value");
            // グラフの種類を折れ線グラフに指定
            dataSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            // グラフのX軸の型をDateTimeに設定
            dataSeries.XValueType = ChartValueType.DateTime;
            // 線の太さを5に設定
            dataSeries.BorderWidth = 5;

            // ChartAreaの取得
            ChartArea area = chartMonitor.ChartAreas[0];

            // X軸のラベル書式を設定
            area.AxisX.LabelStyle.Format = "HH:mm:ss";
            // X軸のタイトルを設定
            area.AxisX.Title = "時間[HH:mm:ss]";
            area.AxisX.TitleFont = new Font("Yu Gothic UI", 10, FontStyle.Bold);
            area.AxisX.TitleAlignment = StringAlignment.Center;

            // X軸のフォントを設定
            area.AxisX.LabelStyle.Font = new Font("Yu Gothic UI", 10, FontStyle.Bold);

            // X軸の間隔を5秒に設定
            area.AxisX.IntervalType = DateTimeIntervalType.Seconds;
            area.AxisX.Interval = 5;

            // Y軸のタイトルを設定
            area.AxisY.Title = "センサー値(模擬)";
            area.AxisY.TitleFont = new Font("Yu Gothic UI", 10, FontStyle.Bold);
            area.AxisY.TitleAlignment = StringAlignment.Center;

            // Y軸のフォントを設定
            area.AxisY.LabelStyle.Font = new Font("Yu Gothic UI", 10, FontStyle.Bold);

            // Y軸の範囲を設定
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 70000;

            // Y軸の間隔を10000に設定
            area.AxisY.Interval = 10000;
        }

        // Startボタン押下
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            // Startボタン無効化
            buttonStart.Enabled = false;
            // Stopボタン有効化
            buttonStop.Enabled = true;
            // Startボタン背景色変更
            buttonStart.BackColor = System.Drawing.Color.LightGray;
            // Stopボタン背景色変更
            buttonStop.BackColor = System.Drawing.Color.White;
            // コントローラのStartメソッド呼び出し
            controller.Start();
        }

        // Stopボタン押下
        private void ButtonStop_Click(object sender, EventArgs e)
        {
            // Stopボタン無効化
            buttonStop.Enabled = false;
            // Startボタン有効化
            buttonStart.Enabled = true;
            // Stopボタン背景色変更
            buttonStop.BackColor = System.Drawing.Color.LightGray;
            // Startボタン背景色変更
            buttonStart.BackColor = System.Drawing.Color.White;
            // コントローラのStopメソッド呼び出し
            controller.Stop();
        }

        // しきい値変更時
        private void NumericThreshold_ValueChanged(object sender, EventArgs e)
        {
            // しきい値設定
            controller.SetThreshold((int)numericThreshold.Value);
        }

        // インターバル変更時
        private void NumericInterval_ValueChanged(object sender, EventArgs e)
        {
            // インターバル設定
            controller.SetInterval((int)numericInterval.Value);
        }

        // CheckResetボタン押下
        private void ButtonCheckReset_Click(object sender, EventArgs e)
        {
            if (labelAlertStatus.Text == "正常")
            {
                // 正常時は何もしない
                return;
            }

            // アラート表示のリセット
            labelAlertStatus.Text = "正常";
            labelAlertStatus.BackColor = System.Drawing.Color.GreenYellow;

            // ボタン背景色を元に戻す
            buttonCheckReset.BackColor = System.Drawing.Color.LightGray;
            // ボタン無効化
            buttonCheckReset.Enabled = false;
        }

        // フォームクローズ時
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // インターバル設定の保存
            Properties.Settings.Default.TimeInterval = (int)numericInterval.Value;
            // しきい値設定の保存
            Properties.Settings.Default.Threshold = (int)numericThreshold.Value;
            // 設定の保存
            Properties.Settings.Default.Save();
        }
    }
}
