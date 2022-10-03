using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Timers;
using System.IO;

namespace Alarm501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            System.Timers.Timer alarmTimer = new System.Timers.Timer(1000);
            alarmTimer.Elapsed += CheckAlarms;
            alarmTimer.SynchronizingObject = this;
            alarmTimer.AutoReset = true;
            alarmTimer.Start();

            //ReadFromJson();

        }


        public List<Alarm> AlarmsList = new List<Alarm>();
        public List<Alarm> EditableAlarmList = new List<Alarm>();


        private void CheckAlarms(object sender, ElapsedEventArgs e)
        {
            DateTime current = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            foreach(Alarm a in AlarmsList)
            {
                if (a.AlarmStatus == "Running" && TimeSpan.Compare(a.AlarmTime.TimeOfDay, current.TimeOfDay) == 0)
                {
                    SignalAlarm(a);
                }
            }
        }

        private void SignalAlarm(Alarm a)
        {
            int index = AlarmsList.IndexOf(a);
            a.AlarmStatus = "GOING OFF";

            alarmGoingOFFTextBox.Text = "Alarm WENT OFF";
            alarmListBox.Items[index] = a;

        }




        private void add_Button_Click(object sender, EventArgs e)
        {
            PopupForm popup = new PopupForm();
          
            
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                Alarm a = new Alarm(popup.GetDPopupDate(), popup.GetPopupStatus());
                AlarmsList.Add(a);
                alarmListBox.Items.Add(a);
                if (alarmListBox.Items.Count > 0)
                {
                    edit_Button.Enabled = true;
                }

                //WriteToJson();
            }
            else if (dialogresult == DialogResult.Cancel)
            {
                
            }
            popup.Dispose();
        }

        private void edit_Button_Click(object sender, EventArgs e)
        {
            PopupForm popup = new PopupForm();

            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                Alarm a = new Alarm(popup.GetDPopupDate(), popup.GetPopupStatus());
                int index = alarmListBox.SelectedIndex;
                alarmListBox.Items.RemoveAt(index);
                alarmListBox.Items.Insert(index, a);
                AlarmsList[index] = a;


            }
            else if (dialogresult == DialogResult.Cancel)
            {

            }
            popup.Dispose();
        }



        private void WriteTextToFile()
        {



        }

        private Alarm MakeAlarmFromListBox()
        {
            int i = 0;
            while (alarmListBox.Items[i] != alarmListBox.SelectedItem) i++;
            return AlarmsList[i];
        }

        private void snooze_Button_Click(object sender, EventArgs e)
        {
            DateTime current = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            Alarm a = MakeAlarmFromListBox();
            int index = AlarmsList.IndexOf(a);
            alarmGoingOFFTextBox.Text = "";

            a.AlarmTime = current.AddSeconds(10);
            a.AlarmStatus = "Running";

            alarmListBox.Items[index] = a;

        }

        private void stopButton_Click(object sender, EventArgs e)
        {

        }

        private void ReadFromJson()
        {
            string filename = "..\\..\\alarms.json";
            string jsonString = File.ReadAllText(filename);
            if(jsonString == "{}")
            {
                return;
            }
            else
            {
                List<Alarm> alarms = JsonSerializer.Deserialize<List<Alarm>>(jsonString);
                foreach(Alarm alarm in alarms)
                {
                    AlarmsList.Add(alarm);
                }
            }
;
        }

        private void WriteToJson()
        {
            List<Alarm> alarms = new List<Alarm>();
            foreach(Object obj in AlarmsList)
            {
                if(obj is Alarm alarm)
                {
                    alarms.Add(alarm);
                }
            }
            string filename = "..\\.\\alarms.json";
            string jsonString = JsonSerializer.Serialize<List<Alarm>>(alarms);
            File.WriteAllText(filename, jsonString);

        }
    }




}
