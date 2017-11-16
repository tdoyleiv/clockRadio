using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.cs
{
    public class ClockRadio
    {
        public string currentTime;
        public bool isAlarmOn;
        public string currentRadioStation;
        public string currentAlarmTime;
        public ClockRadio(string currentTime, bool isAlarmOn, string currentRadioStation, string currentAlarmTime)
        {
            this.currentTime = currentTime;
            this.isAlarmOn = isAlarmOn;
            this.currentRadioStation = currentRadioStation;
            this.currentAlarmTime = currentAlarmTime;
            ShowStatus();
            TimeSet();
            RadioSet();
            AlarmSet();
        }
        public void ShowTime()
        {
            Console.WriteLine("The current time is " + currentTime + ".");
        }
        public void ShowRadioStation()
        {
            Console.WriteLine("You're listening to: " + currentRadioStation + ".");
        }
        public void ShowAlarmSetting()
        {
            if(isAlarmOn)
            {
                Console.WriteLine("The alarm is currently on.");
            }
            else
            {
                Console.WriteLine("The alarm is currently off.");
                AlarmSet();
            }
        }
        public void SetCurrentTime()
        {
            Console.WriteLine("What is the current time?");
            currentTime = Console.ReadLine();
            ShowTime();
        }
        public void SetRadioStation()
        {
            Console.WriteLine("What radio station would you like to hear?");
            currentRadioStation = Console.ReadLine();
            ShowRadioStation();

        }
        public void SetAlarmTime()
        {
            Console.WriteLine("When would you like to set your alarm?");
            currentRadioStation = Console.ReadLine();
            ShowAlarmSetting();

        }
        public void ShowStatus()
        {
            ShowTime();
            ShowRadioStation();
            ShowAlarmSetting();
        }

        public void TimeSet()
        {
            Console.WriteLine("Would you like to reset the current time? Press Y/N");
            ConsoleKeyInfo info = Console.ReadKey();
            if ((info.KeyChar == 'Y') || (info.KeyChar == 'y'))
            {
                SetCurrentTime();
            }
            else if ((info.KeyChar == 'N') || (info.KeyChar == 'n'))
            {
            }
        }
        public void RadioSet()
        {
            Console.WriteLine("Would you like to change the radio station? Press Y/N");
            ConsoleKeyInfo info = Console.ReadKey();
            if ((info.KeyChar == 'Y') || (info.KeyChar == 'y'))
            {
                SetRadioStation();
            }
            else if ((info.KeyChar == 'N') || (info.KeyChar == 'n'))
            {
            }
        }
        public void AlarmSet()
        {
            Console.WriteLine("Would you like to set an alarm? Press Y/N");
            ConsoleKeyInfo info = Console.ReadKey();
            if ((info.KeyChar == 'Y') || (info.KeyChar == 'y'))
            {
                isAlarmOn = true;
                SetAlarmTime();

            }
            else if ((info.KeyChar == 'N') || (info.KeyChar == 'n'))
            {
            }
        }


    }
}
