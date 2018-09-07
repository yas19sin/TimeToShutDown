using System.Windows.Forms;
using System.Timers;
using System;
using System.Diagnostics;

namespace TimeToShutDown
{
    public partial class Form1 : Form
    {

        private static int Time, TimeinSecs;
        private static bool Started;
        private static bool Start;

        public Form1()
        {
            InitializeComponent();

            var aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += OnTimeUpdate;
            aTimer.Enabled = true;
            InfoTxtBox.Text = "00:00:00";
            InfoLabel.Text = "No Info Avaliable";
            //InfoLabel.Text = "" + TimeSpan.MaxValue.TotalSeconds; ;
            Started = false;
            Start = false;
        }

        public void OnTimeUpdate(Object source, ElapsedEventArgs e)
        {
            if (Start)
            {
                Started = true;
                Time -= 1;
                InfoTxtBox.Invoke((MethodInvoker)(() => InfoTxtBox.Text = TimeSpan.FromSeconds(Time).ToString(@"hh\:mm\:ss")));
                if (Time <= 5)
                {
                    InfoLabel.Invoke((MethodInvoker)(() => InfoLabel.Text = "Shutting Down in: " + Time));
                }
                if (Time <= 0)
                {
                    ShutDown();
                }
            }
            else
            {
                Started = false;
            }
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            //Time = Convert.ToInt32(txtBoxTime.Text);
            CounterReady();
        }

        private void CounterReady()
        {
            if (!Started)
            {
                if (int.TryParse(txtBoxTime.Text, out TimeinSecs))
                {
                    if (TimeinSecs > TimeSpan.MaxValue.TotalSeconds)
                    {
                        TimeinSecs = (int)TimeSpan.MaxValue.TotalSeconds;
                    }
                    else
                    {
                        Time = TimeinSecs;
                    }
                    InfoLabel.Text = "Starting...";
                    Start = true;
                }
                else
                {
                    InfoLabel.Text = "Please Enter a Valid Number!.";
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to start a New Counter ?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Started = false;
                    if (int.TryParse(txtBoxTime.Text, out TimeinSecs))
                    {
                        if (TimeinSecs > TimeSpan.MaxValue.TotalSeconds)
                        {
                            TimeinSecs = (int)TimeSpan.MaxValue.TotalSeconds;
                        }
                        else
                        {
                            Time = TimeinSecs;
                        }
                        InfoLabel.Text = "Restarting...";
                        InfoTxtBox.Text = "00:00:00";
                        Start = true;
                    }
                    else
                    {
                        InfoLabel.Text = "Please Enter a Valid Number!.";
                    }
                }
                else if (result == DialogResult.No)
                {
                    Started = true;
                    InfoLabel.Text = "Continuing...";
                }
            }
        }
        private void ShutDown()
        {
            InfoLabel.Invoke((MethodInvoker)(() => InfoLabel.Text = "Shutting Down..."));
            var psi = new ProcessStartInfo("shutdown", "/s /t 1");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
            Application.Exit();
            Start = false;
        }
    }
}