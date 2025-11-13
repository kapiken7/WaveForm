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
            components = new System.ComponentModel.Container();
            StartButton = new Button();
            StopButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(83, 39);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(94, 29);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(218, 39);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(94, 29);
            StopButton.TabIndex = 1;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(387, 43);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 2;
            label1.Text = "現在値：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(462, 43);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 3;
            label2.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Button StopButton;
        private Label label1;
        private Label label2;
    }
}
