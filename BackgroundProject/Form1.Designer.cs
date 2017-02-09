namespace BackgroundProject
{
    partial class BackgroundWorker
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.min = new System.Windows.Forms.TextBox();
            this.max = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.foundedNumbersAmount = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.MessagePrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // min
            // 
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.min.Location = new System.Drawing.Point(28, 40);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(116, 26);
            this.min.TabIndex = 0;
            // 
            // max
            // 
            this.max.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.max.Location = new System.Drawing.Point(155, 40);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(116, 26);
            this.max.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(24, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ilość odnalezionyhc liczb";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // foundedNumbersAmount
            // 
            this.foundedNumbersAmount.AutoSize = true;
            this.foundedNumbersAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.foundedNumbersAmount.Location = new System.Drawing.Point(253, 85);
            this.foundedNumbersAmount.Name = "foundedNumbersAmount";
            this.foundedNumbersAmount.Size = new System.Drawing.Size(18, 20);
            this.foundedNumbersAmount.TabIndex = 4;
            this.foundedNumbersAmount.Text = "0";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StartButton.Location = new System.Drawing.Point(155, 128);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(116, 45);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 195);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(243, 23);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(28, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MessagePrompt
            // 
            this.MessagePrompt.AutoSize = true;
            this.MessagePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MessagePrompt.Location = new System.Drawing.Point(24, 9);
            this.MessagePrompt.Name = "MessagePrompt";
            this.MessagePrompt.Size = new System.Drawing.Size(204, 20);
            this.MessagePrompt.TabIndex = 8;
            this.MessagePrompt.Text = "Rozpocznij wyszukiwanie:";
            // 
            // BackgroundWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 234);
            this.Controls.Add(this.MessagePrompt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.foundedNumbersAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Name = "BackgroundWorker";
            this.Text = "BackgroundWorker";
            this.Load += new System.EventHandler(this.BackgroundWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.TextBox max;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label foundedNumbersAmount;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label MessagePrompt;
    }
}

