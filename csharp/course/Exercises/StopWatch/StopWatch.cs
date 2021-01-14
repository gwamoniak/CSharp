using System;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime StartTime;
        private DateTime StopTime;
        private TimeSpan elapsedTime;
        private string text = "";
        private Boolean isRunning = false; // initilize ?
        public void Start()
        {
            if (isRunning)
                throw new InvalidOperationException("StopWatch: already running");

            StartTime = DateTime.Now;
            isRunning = true;
        }

        public void Stop()
        {
            if (!isRunning)
                throw new InvalidOperationException("StopWatch: not running, click Start");

            StopTime = DateTime.Now;
            isRunning = false;
        }

        public void Reset()
        {
            StartTime =  DateTime.MinValue;
            StopTime  =  DateTime.MinValue;
            elapsedTime  =  TimeSpan.Zero;
            text = "";
            isRunning = false;
        }

        public void Display()
        {
            elapsedTime = StopTime - StartTime;
            int tenths = elapsedTime.Milliseconds / 100;
            
            text +=
                   elapsedTime.Hours.ToString("00") + ":" +
                   elapsedTime.Minutes.ToString("00") + ":" +
                   elapsedTime.Seconds.ToString("00") + "." +
                   tenths.ToString("0");
            
            Console.WriteLine(text);
        }

    }
}
