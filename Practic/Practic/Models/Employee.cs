using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic.Models
{
    internal class Employee
    {
        public string gullName;
        public string address;
        public int age;
        public decimal solary;

        public void Test() 
        {
            //int a = 5;
            //string b = "Welcome";

            //Console.WriteLine("Avertisment" + a + b);

            Book book = new Book();
            book.ShowAdvert();

            Console.WriteLine("test");
        }
    }
}
