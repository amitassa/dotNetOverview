using System;
using System.Collections.Generic;
using System.Text;

namespace Overview
{
    class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;
        private int _miliseconds;

        public Time (int hours, int min, int sec, int milisec)
        {
            _hours = hours;
            _miliseconds = milisec;
            _minutes = min;
            _seconds = sec;
        }
    }
}
