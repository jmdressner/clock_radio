using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock_radio
{
    class ClockRadio
    {
        // member variables

        public string time;
        public string alarm;
        public string setTime;
        public string setAlarmTime;
        public string radioStation;
        public string setRadioStation;

        // constructor

        public ClockRadio()
        {

        }

        // member methods

        public string GetTime()
        {
            Console.WriteLine("Would you like to change the time? Please enter 'Yes' or 'No'.");
            time = Console.ReadLine().ToLower();
            if (time == "yes")
            {
                Console.WriteLine("What time would you like to change the time to?");
                setTime = Console.ReadLine();
                Console.WriteLine("You set the time to: " + setTime);
                return setTime;
            }
            else if (time == "no")
            {
                Console.WriteLine("You did not change the time.  The date and time is still: " + DateTime.Now);
            }
            else
            {
                Console.WriteLine("That was not a valid input. Please press enter to continue.");
                Console.ReadLine();
                GetTime();
            }
            return time;
        }
       
        public string SetAlarm()
        {
            Console.WriteLine("Would you like to set an alarm? Please enter 'Yes' or 'No'");
            alarm = Console.ReadLine().ToLower();
            if (alarm == "yes")
            {
               Console.WriteLine("What time would you like to set your alarm?");
                setAlarmTime = Console.ReadLine();
                Console.WriteLine("You set your alarm to: "+ setAlarmTime);
                return setAlarmTime;
            }
            else if (alarm == "no")
            {
                Console.WriteLine("The alarm is off");
            }
            else
            {
                Console.WriteLine("That was not a valid input. Please press enter to continue.");
                Console.ReadLine();
                SetAlarm();
            }
            return alarm;
        }

        public string SetRadioStation()
        {
            Console.WriteLine("Would you like to change the Radio Station? Please enter 'Yes' or 'No'");
            radioStation = Console.ReadLine().ToLower();
            if (radioStation == "yes")
            {
                Console.WriteLine("What station would you like?");
                setRadioStation = Console.ReadLine();
                Console.WriteLine("You set the radio station to: " + setRadioStation);
                return setRadioStation;
            }
            else if (radioStation == "no")
            {
                Console.WriteLine("The radio is off.");
            }
            else
            {
                Console.WriteLine("That was not a valid input. Please press enter to continue.");
                Console.ReadLine();
                SetRadioStation();
            }
            return radioStation;
        }


    }
}
