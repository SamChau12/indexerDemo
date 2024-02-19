using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
    internal class Program
    {
        // declare an array to store elements  
        private string[] studentName = new string[10];
        // define an indexer
        public string this[int index]
        {
            get
            {
                // return value of stored at studentName array  
                return studentName[index];
            }

            set
            {
                // assigns value to studentName  
                studentName[index] = value;
            }
        }
        static void Main(string[] args)
        {
            // create instance of Program class 
            Program obj = new Program();

            // insert values in obj[] using indexer i.e index position
            obj[0] = "Harry";
            obj[1] = "Ron";
            obj[2] = "Hermoine";

            Console.WriteLine("First element in obj: " + obj[0]);
            Console.WriteLine("Second element in obj: " + obj[1]);
            Console.ReadLine();
        }
    }
}

