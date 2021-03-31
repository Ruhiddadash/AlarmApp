using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace AlarmApp
{
    public partial class Main : Form
    {
        private Stopwatch stopwatch;
        public Main()
        {
            InitializeComponent();
        }
        SoundPlayer sound = new SoundPlayer("Alarm Sound.wav");
        private void Main_Load(object sender, EventArgs e)
        {
            timer_current.Start();
            lbl_date.Text = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
            stopwatch = new Stopwatch();
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            timer_alarm.Start();
            try
            {
                if (lbl_hour.Text == cb_hour.Text && lbl_minute.Text == cb_minute.Text && lbl_second.Text == cb_second.Text)
                {
                    sound.Play();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Time!");
                return;
            }
            lbl_status.Text = "Alarm is set.";
        }

        private void timer_alarm_Tick(object sender, EventArgs e)
        {
            

            if(cb_hour.Text == lbl_hour.Text && cb_minute.Text == lbl_minute.Text && cb_second.Text == lbl_second.Text)
            {
                sound.Play();
                timer_alarm.Stop();
                MessageBox.Show("Wakey Wakey");
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            sound.Stop();
            timer_alarm.Stop();
            lbl_status.Text = "Alarm removed.";
        }

        private void timer_current_Tick(object sender, EventArgs e)
        {
            lbl_hour.Text = DateTime.Now.Hour.ToString();
            lbl_minute.Text = DateTime.Now.Minute.ToString();
            lbl_second.Text = DateTime.Now.Second.ToString();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    MessageBox.Show("Alarm Clock is one of the best alarm clock, making your life alarmy and remindly. It is a must have app, much better than system clock. With wake up alarm, you will never missing important things, no more late for school or work. Remind you anything should not be forgot.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Keys.F11:
                    MessageBox.Show("Please contact ruhiddadash@gmail.com", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void btn_swstart_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
        }

        private void btn_swpause_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void btn_swreset_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }

        private void timer_count_Tick(object sender, EventArgs e)
        {
            this.lbl_countdown.Text = string.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
    }
}
