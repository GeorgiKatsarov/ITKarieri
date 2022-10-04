using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeMine
{
    internal class Time
    {
        private int seconds;
        private int minutes;
        private int hours;
        public int Seconds
        {
            get { return seconds; }
            set
            {
                while (value > 60)
                {
                    Console.WriteLine("Seconds can't be bigger than 60, enter a new value");
                    
                    
                    int value1 = int.Parse(Console.ReadLine());
                    while (value1 > 60)
                    {
                        value1 = int.Parse(Console.ReadLine());
                    }
                    value = value1;
                    break;
                }
                seconds = value;
                

            }
        }
        public int Minutes
        {
            get { return minutes; }
            set
            
            {
                while (value > 60)
                {
                    Console.WriteLine("Minutes can't be bigger than 60, enter a new value");
                    int value1 = int.Parse(Console.ReadLine());
                    while (value1 > 60)
                    {
                        value1 = int.Parse(Console.ReadLine());
                    }
                    value = value1;
                    break;
                }
                minutes = value;
                

            }
        }
        public int Hours
        {
            get { return hours; }
            set
            {
                while (value > 24)
                {
                    Console.WriteLine("Hours can't be bigger than 24, enter a new value");
                    int value1 = int.Parse(Console.ReadLine());
                    while (value1 > 24)
                    {
                        value1 = int.Parse(Console.ReadLine());
                    }
                    value = value1;
                    break;
                }
                hours = value;
                

            }
        }
        public Time(int secunds, int minutes, int hours)
        {
            Seconds = secunds;
            Minutes = minutes;
            Hours = hours;
        }
        public void TellTime()
        {
            Console.WriteLine($"The time is {this.Hours}:{this.Minutes}:{this.Seconds}");
        }
    }
}
