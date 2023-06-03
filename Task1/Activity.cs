using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    public class Activity
    {
        private int ActID;       // activity identifier
        private String ActName;  // description of activity

        public Activity(int ID, String Name)
        {
            ActID = ID;
            ActName = Name;
        }

        public void display()
        {
            Console.WriteLine("ID: {0} Description: {1} ", ActID, ActName);
        }

        public int CompareTo(Activity other)
        {
            return this.ActID - other.ActID;
        }

        public String getName()
        {
            return ActName;
        }

    }
}
