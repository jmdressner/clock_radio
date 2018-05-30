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
            ClockRadio myRadio = new ClockRadio();
            myRadio.GetTime();
            //Console.WriteLine(myRadio.time);
            Console.ReadLine();
            myRadio.SetAlarm();
            //Console.WriteLine(myRadio.alarm);
            Console.ReadLine();
            myRadio.SetRadioStation();
            //Console.WriteLine(myRadio.radioStation);
            Console.ReadLine();
        }
    }
}
