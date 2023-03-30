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

            Console.WriteLine(crono1.Elapsed);
            Console.WriteLine(crono2.Elapsed);
        }
    }
}
