using System;
using System.Dynamic;

namespace DateTimeMine
{
    public class DateTimeMine
    {
        public static void Main()
        {
            Time time = new Time(89, 42, 13);
            Time time2 = new Time(59, 42, 26);
            time.TellTime();
            time2.TellTime();
            

        }
    }
}