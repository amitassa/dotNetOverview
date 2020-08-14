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

        public void ShowTime()
        {
            string hourShow = _hours.ToString();
            string minShow = _minutes.ToString();
            string secShow = _seconds.ToString();
            string milisecShow = _miliseconds.ToString();
            if (_hours < 10)
                hourShow = "0" + _hours;
            if (_minutes < 10)
                minShow = "0" + _minutes;
            if (_seconds < 10)
                secShow = "0" + _seconds;
            if (_miliseconds < 100)
                if (_miliseconds < 10)
                    milisecShow = "00" + _miliseconds;
                else
                    milisecShow = "0" + _miliseconds;
            
            Console.WriteLine($"{}");
        }
    }
}
