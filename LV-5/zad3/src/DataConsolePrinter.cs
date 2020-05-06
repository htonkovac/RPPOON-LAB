using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV5
{

    class DataConsolePrinter
    {

        public void PrintDataset(IDataset dataset)
        {
            ReadOnlyCollection<List<String>> data = dataset.GetData();
            if (data == null)
            {
                System.Console.WriteLine("DATA INACESSIBLE");
                return;
            }

            foreach (List<String> row in data)
            {
                foreach (String item in row)
                {
                    Console.Write(item);
                    if (item != row.Last())
                    {
                        Console.Write(",");
                    }
                }
                Console.WriteLine();
            }
        }
    }

}

