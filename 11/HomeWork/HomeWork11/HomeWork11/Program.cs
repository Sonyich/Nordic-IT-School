using System;

namespace HomeWork11
{
    public partial class ReminderItem
    {
        private DateTimeOffset _alarmDate;
        private string _alarmMessage;
            
        public DateTimeOffset AlarmDate
        {
            get
            {
                return _alarmDate;
            }
            set
            {
                _alarmDate = value;
            }
        }

        public string AlarmMessage
        {
            get
            {
                return _alarmMessage;
            }

            set
            {
                _alarmMessage = value;
            }
        }

        public TimeSpan TimeToAlarm
        {
            get
            {
                return (DateTimeOffset.Now - AlarmDate);
            }
        }

        public bool IsOutdated
        {
            get
            {
                if (TimeToAlarm < TimeSpan.Parse("0:00:00"))
                    return false;
                else
                    return true;
            }
        }
    }

    public partial class ReminderItem
    {
        public ReminderItem(DateTimeOffset alarmDate, string alarmMessage)
        {
            AlarmDate = alarmDate;
            AlarmMessage = alarmMessage;
        }

        /// <summary>
        /// Creates a new instance of ReminderItem class.
        /// </summary>
        /// <param name="AlarmDate">Date of the alarm.</param>
        /// <param name="AlarmMessage">Message of the alarm.</param>

        public void WriteProperties()
        {
            Console.WriteLine($"AlarmDate: {AlarmDate}" + "\n"
                + $"AlarmMessage: {AlarmMessage}" + "\n"
                + $"TimeToAlarm: {TimeToAlarm}" + "\n"
                + $"IsOutdated: {IsOutdated}");        
        }
    }

    class Program
    {
        static void Main(string[] args)
        {           
            ReminderItem remind1 = new ReminderItem(DateTimeOffset.Parse ("7:00:00 AM"), "It is time to wake up!");
            ReminderItem remind2 = new ReminderItem(DateTimeOffset.Parse("7:15:00 AM"), "It is time to WAKE UP!");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Remind1: " + "\n");
            Console.ResetColor();
            remind1.WriteProperties() ;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + "Remind2: " + "\n");
            Console.ResetColor();
            remind2.WriteProperties();

        }
    }
}
