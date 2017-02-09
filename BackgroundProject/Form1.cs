using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundProject
{
    public partial class BackgroundWorker : Form
    {
        int[] tab = new int[2];
        public BackgroundWorker()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int[] tab2 = (int[]) e.Argument;
            int iloscLiczb = tab2[1] - tab2[0] + 1;
            Console.WriteLine("Ilosc liczb: " + iloscLiczb);
            int progress = 0;
            int ilosc = 0;
            bool czyPierwsza;

            int cnt = 0;

            for (int i = tab[0]; i <= tab[1]; i++)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                czyPierwsza = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        czyPierwsza = false;
                        break;
                    }
                }
                cnt++;

                Thread.Sleep(500);
                
                if (czyPierwsza)
                {
                    ilosc++;
                }

                float iloscKFl = iloscLiczb;
                float iloscFl = cnt; 

                float progressFl = (iloscFl / iloscKFl) * 100;
                Console.WriteLine("ProgressFl:" + progressFl);
                progress = (int) progressFl;
                Console.WriteLine("Progress: " + progress);
                backgroundWorker1.ReportProgress(progress, ilosc); 
            }  
            
                     
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            tab[0] = Int32.Parse(min.Text);
            tab[1] = Int32.Parse(max.Text);
            backgroundWorker1.RunWorkerAsync(tab);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int ilosc = (int) e.UserState;

            foundedNumbersAmount.Text = ilosc.ToString();
            progressBar1.Value = (int)e.ProgressPercentage;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            String message = "";

            if (e.Cancelled == true)
            {
                message = "Anulowano";
            }
            else if (e.Error != null)
            {
                message = "Błąd";
            }
            else
            {
                message = "Wykonano";
            }

            progressBar1.Value = 0;

            MessagePrompt.Text = message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void BackgroundWorker_Load(object sender, EventArgs e)
        {

        }
    }
}
