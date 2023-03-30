using System;
using System.Diagnostics;
using System.Threading;

namespace Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();
            Thread.Sleep(500);

            crono2.Start();
            Thread.Sleep(300);

            crono1.Stop();
            crono2.Stop();

            TimeSpan ts1 = crono1.Elapsed;
            TimeSpan ts2 = crono2.Elapsed;

            string ts1Sec = ts1.ToString("ss\\.ff");
            string ts2Sec = ts2.ToString("ss\\.ff");

            Console.WriteLine(ts1Sec);
            Console.WriteLine(ts2Sec);
        }
    }
}
