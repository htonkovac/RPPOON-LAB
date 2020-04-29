using System;
using System.Linq;
namespace LV1
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;

        }
        public double[] PerColumnAverage(double[][] data)
        {
            int rowCount = data.Length;
            int columnCount = data[0].Length;

            double[] results = new double[columnCount];
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    results[j] += data[i][j] / rowCount;
                }
            }
            return results;
        }
    }
}
