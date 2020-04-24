using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
  
   /**
     * Jednom postavljena datoteka uvijek ce se koristiti sve dok se ne promjeni putem svojstva,
     * bez obzira u kojem dijelu programa je pozvana, posto se radi o singletonu.
     */   
    class Logger
    {
        private static Logger instance;
        private string filePath;
        
        private Logger()
        {
            this.filePath = System.AppDomain.CurrentDomain.BaseDirectory + "log.txt";
        }

        public static Logger GetInstance()
        {
            if(instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
       
        public void Log(string text)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath, true))
            {
                writer.WriteLine(text.ToString());

            }

        }

        public string FilePath
        {
            set { this.filePath = value; }
            get { return this.filePath; }
        }
    }
}
