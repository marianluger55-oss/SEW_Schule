using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StopWatch
{
    internal class StopWatch
    {
        private DateTime start; 

        public StopWatch() 
        {
            this.start = DateTime.Now;    
        }

        public double ElapsedSec()
        {
            return (DateTime.Now - start).TotalSeconds;

        }

        public void Reset()
        {
            this.start = DateTime.Now; 
        }
    }
}

// Bsp.: ReactionTime mit Stopwatch


