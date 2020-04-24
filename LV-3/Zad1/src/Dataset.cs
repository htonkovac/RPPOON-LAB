using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Dataset: Prototype
    {
        private List<List<string>> data;
        public Dataset()
        {
            this.data = new List<List<string>>();
        }

        public Dataset(string filePath): this()
        {
            this.LoadDataFromCSV(filePath);
        }

        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach(string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }

        public IList<List<string>> GetData()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }

        public void ClearData()
        {
            this.data.Clear();
        }

        public Prototype Clone()
        {
            Dataset clone = (Dataset)this.MemberwiseClone();   
            clone.data = new List<List<string>>(this.data.Count);
            foreach(List<string> datum in this.data)
            {
                List<string> clonedDatum = datum.Select(x => x).ToList();
                clone.data.Add(clonedDatum);
            }
            return clone;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach(List<string> data1 in this.data)
            {
                foreach(string data2 in data1)
                {
                    builder.Append(data2);
                }
                builder.Append("\n");
            }
            return builder.ToString();
        }
    }
}
