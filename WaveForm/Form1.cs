using System;
using System.Windows.Forms;

namespace WaveForm
{
    public partial class MainForm : Form
    {
        private readonly DataController controller;

        public MainForm()
        {
            InitializeComponent();

            controller = new DataController();

            // データ生成完了通知用デリゲート登録
            controller.DataGenerated = (int value) =>
            {
                label2.Text = value.ToString();
            };
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
    }
}
