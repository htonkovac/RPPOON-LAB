using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV5
{
    class User
    {
        private static int id = 0;
        public string Name { get; private set; }
        public int ID { get; private set; }
        private User(string name, int ID)
        {
            this.Name = name;
            this.ID = ID;
        }
        public static User GenerateUser(string name)
        {
            id++;
            return new User(name, id);
        }
    }
}
