using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    public partial class PopupForm : Form
    {
        public PopupForm()
        {
            InitializeComponent();
            dateTimePicker.Format = DateTimePickerFormat.Time;

           
            
        }

        public DateTime GetDPopupDate()
        {
            DateTime date = dateTimePicker.Value;
            
            return date;
        }

        public string GetPopupStatus()
        {
            if (onOffCheckBox.Checked)
            {
                return "Running";
            }
            else
            {
                return "Off";
            }
        }

        public void SetTime(DateTime time)
        {
            dateTimePicker.Value = time;

        }

        public void Check(bool isChecked)
        {
            if (isChecked) onOffCheckBox.Checked = true;
            else onOffCheckBox.Checked = false;
        }



        
    }
}
