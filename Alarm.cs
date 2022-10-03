using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm501
{
    public class Alarm
    {
        public DateTime AlarmTime { get; set; }

        public string AlarmStatus { get; set; }

        public override string ToString()
        {
            string[] whatever = AlarmTime.ToString().Split(" ");
           
            return whatever[1] + " " + whatever[2] + " " + AlarmStatus.ToString();
        }

        public Alarm(DateTime time, string status)
        {
            AlarmTime = time;
            AlarmStatus = status;

        }

    }
}
