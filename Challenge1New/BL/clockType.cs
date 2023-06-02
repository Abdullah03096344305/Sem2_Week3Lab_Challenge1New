using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1New.BL
{
    class clockType
    {
        public int hours;
        public int minutes;
        public int seconds;
        // Default constructor
        public clockType()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        // Parameterized constructor
        public clockType(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        // Set the time
        public void setTime(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        // Print the time
        public void printTime()
        {          
                Console.WriteLine(hours + ":" + minutes + ":" + seconds);          
        }
        // Increment the time by one second
        public void incrementSec()
        {
            seconds++;
            if (seconds == 60)
            {
                seconds = 0;
                incrementMin();
            }
        }
        // Increment the time by one minute
        public void incrementMin()
        {
            minutes++;
            if (minutes == 60)
            {
                minutes = 0;
                incrementHr();
            }
        }
        // Increment the time by one hour
        public void incrementHr()
        {
            hours++;
            if (hours == 24)
            {
                hours = 0;
            }
        }
        // elapsed time of the day of a clock in seconds
        public int elapsedTimeInSeconds()
        {
            return hours * 3600 + minutes * 60 + seconds;
        }
        //remaining time of the day to a clock in seconds
        public int remainingTimeInSeconds()
        {
            return (24 - hours) * 3600 - minutes * 60 - seconds;
        }
        // checking and outputs how door in time two clocks are
        public void timeDifference(clockType otherClock)
        {
            int thisTimeInSeconds = elapsedTimeInSeconds();
            int otherTimeInSeconds = otherClock.elapsedTimeInSeconds();
            int differenceInSeconds = Math.Abs(thisTimeInSeconds - otherTimeInSeconds);
            int differenceHr = differenceInSeconds / 3600;
            int differenceMin = (differenceInSeconds % 3600) / 60;
            int differenceSec = differenceInSeconds % 60;
            Console.WriteLine(differenceHr + ":" + differenceMin + ":" + differenceSec);
            Console.WriteLine();
        }
        public override string ToString()
        {
            return hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString();
        }

    }
}
