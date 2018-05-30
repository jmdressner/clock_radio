using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock_radio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please hit the enter key to continue through this program.");
            Console.ReadLine();
            Console.WriteLine("This is the Clock Radio Program.");
            Console.WriteLine("The date and time is: " + DateTime.Now);
            Console.ReadLine();
            ClockRadio myRadio = new ClockRadio();
            myRadio.GetTime();
            Console.ReadLine();
            myRadio.SetAlarm();
            Console.ReadLine();
            myRadio.SetRadioStation();
            Console.ReadLine();
            Console.WriteLine("You have reached the end of this program.  Thank you for your time.");
            Console.ReadLine();
        }
    }
}
