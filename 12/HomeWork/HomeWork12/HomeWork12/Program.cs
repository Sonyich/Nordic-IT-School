using System;

namespace HomeWork11
{
    public partial class ReminderItem
    {
        public DateTimeOffset AlarmDate { get; set; }

        public string AlarmMessage { get; set; }

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
        public ReminderItem (DateTimeOffset alarmDate, string alarmMessage)
        {
            AlarmDate = alarmDate;
            AlarmMessage = alarmMessage;
        }

        virtual public void WriteProperties()
        {
            Console.WriteLine(
                $"{GetType().Name}" + "\n" +
                $"AlarmDate: {AlarmDate}" + "\n"
                + $"AlarmMessage: {AlarmMessage}" + "\n"
                + $"TimeToAlarm: {TimeToAlarm}" + "\n"
                + $"IsOutdated: {IsOutdated}");
        }
    }

    public class PhoneReminderItem : ReminderItem
    {
        public string PhoneNumber { get; set; }

        public PhoneReminderItem (
            DateTimeOffset alarmDate, 
            string alarmMessage, 
            string phoneNumber)
            : base (alarmDate, alarmMessage)
        {
            PhoneNumber = phoneNumber;
        }
        override public void WriteProperties()
        {
            Console.WriteLine(
                $"{GetType().Name}" + "\n" +
                $"AlarmDate: {AlarmDate}" + "\n"
                + $"AlarmMessage: {AlarmMessage}" + "\n"
                + $"TimeToAlarm: {TimeToAlarm}" + "\n"
                + $"IsOutdated: {IsOutdated}" + "\n" +
                $"PhoneNumber: {PhoneNumber}"); 
        }
    }

    public class ChatReminderItem : ReminderItem
    {
        public string ChatName { get; set; }
        public string AccountName { get; set; }
        public ChatReminderItem (
            DateTimeOffset alarmDate, 
            string alarmMessage, 
            string chatName, 
            string accountName)
            : base (alarmDate, alarmMessage)
        {
            ChatName = chatName;
            AccountName = accountName;
        }
        override public void WriteProperties()
        {
            Console.WriteLine(
                $"{GetType().Name}" + "\n" +
                $"AlarmDate: {AlarmDate}" + "\n"
                + $"AlarmMessage: {AlarmMessage}" + "\n"
                + $"TimeToAlarm: {TimeToAlarm}" + "\n"
                + $"IsOutdated: {IsOutdated}" + "\n" +
                $"ChatName: {ChatName}" + "\n" +
                $"AccountName: {AccountName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Reminders = new ReminderItem[3];

            Reminders[0] = new ReminderItem(DateTimeOffset.Parse("7:00:00 AM"), "It is time to wake up!");
            Reminders[1] = new PhoneReminderItem(DateTimeOffset.Parse("7:15:00 AM"), "It is time to WAKE UP!", "+79854270698");
            Reminders[2] = new ChatReminderItem(DateTimeOffset.Parse("7:40:00 AM"), "It is real time to WAKE UP!!!!!", "Wakers220", "Sonyich");
                       
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Remind1: " + "\n");
            Console.ResetColor();
            Reminders[0].WriteProperties();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + "Remind2: " + "\n");
            Console.ResetColor();
            Reminders[1].WriteProperties();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + "Remind3: " + "\n");
            Console.ResetColor();
            Reminders[2].WriteProperties();

        }
    }
}
