using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Challenge1New.BL;
using System.Threading.Tasks;

namespace Challenge1New
{
    class Program
    {
        static void Main(string[] args)
        {
            clockType myClock = new clockType(10, 30, 0);
            clockType otherClock = new clockType(14, 45, 0);           
            Console.WriteLine("Elapsed time: " +  myClock.elapsedTimeInSeconds());          
            Console.WriteLine("Remaining time: " +  myClock.remainingTimeInSeconds());            
            Console.Write("Time difference between myClock and otherClock: ");
            myClock.timeDifference(otherClock);            
            myClock.incrementHr();
            Console.Write("myClock time after incrementing by one hour: ");
            myClock.printTime();
            Console.Write("otherClock time: ");
            Console.WriteLine(otherClock);
            if (myClock.ToString() == otherClock.ToString())
            {
                Console.WriteLine("The two clocks have the same time.");
            }
            else
            {
                Console.WriteLine("The two clocks have different times.");
            }
            Console.ReadLine();
        }
    }
}
