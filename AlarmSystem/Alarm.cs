﻿using AlarmSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmSystem
{
    public partial class Alarm : Form
    {
        System.Timers.Timer timer;
        SoundPlayer soundPlayer = new SoundPlayer();
        ClassAlarm alarm;

        int count = 0;
        List<int> repetition;

        public Alarm(ClassAlarm alarm)
        {
            InitializeComponent();
            this.alarm = alarm;
        }

        private void Alarm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
            NextAlarm.Text = setDateTime(alarm).ToString();

            //timer method
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += timer_Elapsed;


        }

        private void SetControls()
        {
            //form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "CustomAlarm";
            AlarmName.Text = alarm.alarmName;
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime alarmTime = setDateTime(alarm);

            if (equalDate(currentTime, alarmTime))
            {
                soundPlayer.SoundLocation = @"C:\iphone_alarm.mp3";
                soundPlayer.PlayLooping();

                if (alarm.repeat)
                {
                    repetition = alarm.repetition;

                    if (count < repetition.Count)
                    {
                        alarmTime.AddDays(repetition[count]);
                        count++;
                        NextAlarm.Text = alarmTime.ToString();
                    }
                    else
                    {
                        count = 0;
                    }
                }
                else
                {
                    timer.Stop();
                    MessageBox.Show("it act worked", TitlesModel.MessageBoxTitle,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }


        }
        
        private DateTime setDateTime(ClassAlarm A)
        {
            int year, month, day, hour, minute;
            string dateAndTime = A.date + " " + A.time;
            string[] converter = dateAndTime.Split(' ');
            
            year = Int32.Parse(converter[0]);
            month = Int32.Parse(converter[1]);
            day = Int32.Parse(converter[2]);
            hour = Int32.Parse(converter[3]);
            minute = Int32.Parse(converter[4]);

            return new DateTime(year, month, day, hour, minute, 0);
        }

        private Boolean equalDate (DateTime A, DateTime B)
        {

            if (A.Year == B.Year && A.Month == B.Month && A.Day == B.Day && A.Hour == B.Hour && A.Minute == B.Minute) return true;

            return false;
        }

        private void setlbl(string txt)
        {

        }

        private void btnStopAlarm_Click(object sender, EventArgs e)
        {
            timer.Stop();
            soundPlayer.Stop();
            this.Dispose();
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
        }
    }
}
