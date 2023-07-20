using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practic.Models
{
    internal class Product
    {
        public int id;
        public string name;
        public decimal price;
        public DateTime CreateDate;

        public Product()
        {
            Console.WriteLine("Welcome");
        }
        public Product(string text):this(DateTime.Now)
        {
            Console.WriteLine("this is my tex : " + text);
        }
        public Product(DateTime date):this(10,15)
        {
            Console.WriteLine("This is my Date" + date);
        }
        public Product(int a, int b):this()
        {
            Console.WriteLine(a+b);
        }
    }
}
