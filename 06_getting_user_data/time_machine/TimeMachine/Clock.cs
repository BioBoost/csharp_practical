using System;
using System.Collections.Generic;
using System.Text;

namespace TimeMachine
{
    public class Clock
    {
        int hours = DateTime.Now.Hour;
        int minutes = DateTime.Now.Minute;

        public void AddHours(int delta)
        {
            // TODO: Add delta to hours
            // Keep in mind that hours should stay in range of [0, 23]
        }

        public void AddMinutes(int delta)
        {
            // TODO: Add delta to minutes
            // Keep in mind that minutes should stay in range of [0, 59]
            // Don't forget to add to hours when it overflows
        }

        public void PrintToTerminal()
        {
            Console.WriteLine($"Time: {hours.ToString("D2")}:{minutes.ToString("D2")}");
        }

        public int Hours { get { return hours; } set { hours = value; } }
        public int Minutes { get { return minutes; } set { minutes = value; } }
    }
}
