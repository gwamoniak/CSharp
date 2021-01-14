using System.Threading;

namespace StopWatch
{

    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            stopWatch.Start();

            // Do something
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }
            stopWatch.Stop();

            stopWatch.Display();
            stopWatch.Reset();
            stopWatch.Display();
        }
    }
}
