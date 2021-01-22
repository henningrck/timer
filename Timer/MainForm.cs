using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class MainForm : Form
    {
        private int hours;
        private int minutes;
        private int seconds;
        private int totalSeconds;

        public MainForm()
        {
            InitializeComponent();
        }

        private void hoursUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                reset();
            }
        }

        private void minutesUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                reset();
            }
        }

        private void secondsUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                reset();
            }
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
            }
            else
            {
                timer.Start();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void onTopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = onTopCheckBox.Checked;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (hours == 0 && minutes == 0 && seconds == 0)
            {
                timer.Stop();
                return;
            }

            seconds--;

            if (seconds < 0)
            {
                minutes--;
                seconds = 59;
            }

            if (minutes < 0)
            {
                hours--;
                minutes = 59;
            }

            updateTimerLabel();
            updateTimerProgressBar();
        }

        private void reset()
        {
            hours = Decimal.ToInt32(hoursUpDown.Value);
            minutes = Decimal.ToInt32(minutesUpDown.Value);
            seconds = Decimal.ToInt32(secondsUpDown.Value);
            totalSeconds = seconds + minutes * 60 + hours * 3600;
            updateTimerLabel();
            updateTimerProgressBar();
        }

        private void updateTimerLabel()
        {
            timerLabel.Text = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
        }

        private void updateTimerProgressBar()
        {
            var currentSeconds = seconds + minutes * 60 + hours * 3600;
            timerProgressBar.Maximum = totalSeconds;
            timerProgressBar.Value = totalSeconds - currentSeconds;
        }
    }
}
