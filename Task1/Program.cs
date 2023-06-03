using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Module WRA202 = new Module();
            StreamReader Input = new StreamReader("Activities.txt");
            Console.WriteLine("Populating binary search tree with WRAV202 activities");
            while (!Input.EndOfStream)
            {
                String inputLine = Input.ReadLine();
                string[] data = inputLine.Split(',');
                Activity Act = new Activity(int.Parse(data[0]), data[1]);
                WRA202.addActivity(Act);
            }
            Console.WriteLine("Tree populated - press enter to continue");
            Console.ReadLine();
            WRA202.displayAscending();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.WriteLine("Finding activity with smallest identifier");
            Activity curAct = WRA202.findMin();
            if (curAct == null)
                Console.WriteLine("List of activities is empty");
            else
                curAct.display();
            Console.WriteLine("Height of tree is {0}", WRA202.height());
            Console.WriteLine("Processing terminated - press enter to continue");
            Console.ReadLine();
        }
    }
}

