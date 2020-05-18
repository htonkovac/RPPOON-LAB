
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV7
{
    abstract class SimpleSystemDataProvider
    {
        private System.Diagnostics.PerformanceCounter cpuCounter;
        private System.Diagnostics.PerformanceCounter ramCounter;
        private List<Logger> loggers;
        public SimpleSystemDataProvider()
        {
            this.cpuCounter =
            new System.Diagnostics.PerformanceCounter("Processor", "% Processor Time", "_Total");
            this.ramCounter =
            new System.Diagnostics.PerformanceCounter("Mono Memory", "Allocated Objects");
            this.loggers = new List<Logger>();
        }
        public float CPULoad { get { return this.cpuCounter.NextValue(); } }
        public float AvailableRAM { get { return this.ramCounter.NextValue(); } }
        public void Attach(Logger logger)
        {
            if (!this.loggers.Contains(logger))
                this.loggers.Add(logger);

        }
        public void Detach(Logger logger)
        {
            this.loggers.Remove(logger);
        }
        public void Notify()
        {
            foreach (Logger logger in this.loggers)
            {
                logger.Log(this);
            }
        }
    }
}
