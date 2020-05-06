using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV5
{
    class LoggingProxyDataset : IDataset
    {
        private ConsoleLogger logger = ConsoleLogger.Instance;
        private Dataset dataset;

        public LoggingProxyDataset(string filePath) {
            this.dataset = new Dataset(filePath);
        }

        public ReadOnlyCollection<List<string>> GetData()
        {
            logger.Log("[ INFO ] : Dataset Accessed at " + DateTime.Now);
            return dataset.GetData();
        }

    }
}
