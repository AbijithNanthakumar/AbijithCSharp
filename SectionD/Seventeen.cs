using System;

namespace AlarmEventExample
{
    public delegate void AlarmEventHandler(object sender, EventArgs e);

    class AlarmClock
    {
        public event AlarmEventHandler AlarmRang;

        public void StartAlarm()
        {
            Console.WriteLine("AlarmClock: It's time! Triggering alarm...");
            OnAlarmRang();  // Raise the event
        }

        protected virtual void OnAlarmRang()
        {
            if (AlarmRang != null)
                AlarmRang(this, EventArgs.Empty);  // Notify all subscribers
        }
    }

    class Ring
    {
        // Event handler method
        public void OnAlarm(object sender, EventArgs e)
        {
            Console.WriteLine("Ring: Beep! Beep! The alarm is ringing.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock alarm = new AlarmClock();
            Ring ring = new Ring();

            // Subscribing to the event
            alarm.AlarmRang += ring.OnAlarm;

            alarm.StartAlarm();

            // Unsubscribe (optional)
            // alarm.AlarmRang -= ring.OnAlarm;
        }
    }
}
