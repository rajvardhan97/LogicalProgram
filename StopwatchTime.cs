using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace LogicalProgram
{
    internal class StopwatchTime
    {
        public void ElapsedTime()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Thread.Sleep(15600);
            watch.Stop();
            TimeSpan tspan = watch.Elapsed;
            string elapsedTime = String.Format(" {0:00}:{1:00}:{2:00}.{3:00} ",
            tspan.Hours, tspan.Minutes, tspan.Seconds, tspan.Milliseconds / 10);
            Console.WriteLine(" RunTime " + elapsedTime);
        }
    }
}
