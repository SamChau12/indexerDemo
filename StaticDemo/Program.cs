using System;

namespace StaticDemo
{
   
        class MyCollege
        {
            //static fields
            public static string CollegeName;
            public static string Address;

            //static constructor
            static MyCollege()
            {
                CollegeName = "ABC College of Technology";
                Address = "Hyderabad";
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                 
                Console.WriteLine(MyCollege.CollegeName);
                Console.WriteLine(MyCollege.Address);
                Console.ReadLine();
            }
        }
    }

