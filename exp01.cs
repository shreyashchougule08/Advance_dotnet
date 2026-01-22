using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 15;   // variable declaration and initialization
            //Console.WriteLine(num);
            //Console.WriteLine("Helo world");

            int mynum = 23;
            char mychar = 'A';
            double mydouble = 23.45;
            bool mybool= true;
            string mystring = "hi";

            Console.WriteLine(mynum);
            Console.WriteLine(mychar);
            Console.WriteLine(mydouble);
            Console.WriteLine(mybool);
            Console.WriteLine(mystring);
            //Arithematic operation 
            int x = 5;
            int y = 10;
            Console.WriteLine("addition " + (x + y));
            Console.WriteLine("substraction " + (x - y));
            Console.WriteLine("multiplication " + (x * y));
            Console.WriteLine("divison " + (x / y));

            // type casting 
            int number = 20;
            double mydoub = number;
            Console.WriteLine("casting " + number);

            // explicit casting
            double value = 23.56;
            int myint = (int) value ;

            Console.WriteLine("expl" +value );
            Console.WriteLine("exp " +myint);

            // user input
            //Console.WriteLine("Enter the age ");
            //string  age =Console.ReadLine();
            //Console.WriteLine("Your Age :" + age);


            int x1 = 5;
            int y2 = 3;
            Console.WriteLine(x1 > y2);

        }
    }
}
