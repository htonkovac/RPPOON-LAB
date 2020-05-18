
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV7
{
    class SystemDataProvider : SimpleSystemDataProvider
    {
        private float previousCPULoad;
        private float previousRAMAvailable;


        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }

        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;
            if (currentLoad >= this.previousCPULoad * 1.1 || currentLoad <= this.previousCPULoad * 0.9)
            {
                this.Notify();
            }
            this.previousCPULoad = currentLoad;
            return currentLoad;
        }
        public float GetAvailableRAM()
        {
            float currentRAM = this.AvailableRAM;

            if (currentRAM > this.previousRAMAvailable * 1.1 || currentRAM < this.previousRAMAvailable * 0.9)
            {
                this.Notify();
            }
            this.previousRAMAvailable = currentRAM;
            return currentRAM;
        }

    }
}
