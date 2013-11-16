using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CountDown
{
    public enum CurrentStatus
    {
        Pause,
        Stop,
        Play,
        Idle
    }

    public partial class Form1 : Form
    {
        protected TimeSpan _timer;
        protected TimeSpan _elapsedTime;
        protected CurrentStatus _status;
        protected TimeSpan _default;
        public Form1()
        {
            InitializeComponent();
            TbMinutes.SelectionStart = 0;
            TbSeconds.SelectionStart = 0;
            _elapsedTime = new TimeSpan(0, 0, 0);
            _default = new TimeSpan(0, 5, 30);
            UpdateElapsedTime();
            _status = CurrentStatus.Idle;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Timer.Enabled)
            {
                _timer = _timer.Subtract(new TimeSpan(0, 0, 1));
                if (_timer.TotalSeconds == 0)
                    Timer.Enabled = false;
                _elapsedTime = _elapsedTime.Add(new TimeSpan(0, 0, 1));
                UpdateElapsedTime();
                UpdateProgressBar();
                UpdateCountDown();
                if ( _timer.TotalSeconds == 0 )
                {
                    MessageBox.Show("Tempo scaduto");
                    this.Stop_Click(sender, e);
                }
            }
        }

        private void UpdateProgressBar()
        {
            pBar.Value = pBar.Value + 1;
            if (pBar.Value >= ((75 * pBar.Maximum) / 100))
            {
                pBar.ForeColor = Color.Orange;
                pBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            }
            else if (pBar.Value >= ((85 * pBar.Maximum) / 100))
            {
                pBar.ForeColor = Color.OrangeRed;
                pBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            }
            else if (pBar.Value >= ((95 * pBar.Maximum) / 100))
            {
                pBar.ForeColor = Color.Red;
                pBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            }
        }

        private void UpdateCountDown()
        {
            this.TbMinutes.Text = _timer.Minutes.ToString("00");
            this.TbSeconds.Text = _timer.Seconds.ToString("00");
        }

        private void UpdateElapsedTime()
        {
            this.lElapsedTime.Text =
                string.Format("{0}h:{1}m:{2}s", _elapsedTime.Hours.ToString("00"), _elapsedTime.Minutes.ToString("00"), _elapsedTime.Seconds.ToString("00"));
        }


        private void Play_Click(object sender, EventArgs e)
        {
            if (_status != CurrentStatus.Pause)
            {
                _timer = new TimeSpan(0, int.Parse(TbMinutes.Text), int.Parse(TbSeconds.Text));
                _default = _timer;
                pBar.Value = 0;
                pBar.Minimum = 0;
                pBar.Maximum = (int)_timer.TotalSeconds;
            }
            Timer.Enabled = true;
            _status = CurrentStatus.Play;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            _status = CurrentStatus.Stop;
            Timer.Enabled = false;
            pBar.Value = 0;
            pBar.Minimum = 0;
            pBar.Minimum = 0;
            this.TbMinutes.Text = _default.Minutes.ToString("00");
            this.TbSeconds.Text = _default.Seconds.ToString("00");
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stop_Click(sender, e);
        }

        private void cancellaTempoTrascorsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _elapsedTime = new TimeSpan(0, 0, 0);
            UpdateElapsedTime();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler uscire?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Dispose();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            _status = CurrentStatus.Pause;
            Timer.Enabled = false;
        }
    }
}
