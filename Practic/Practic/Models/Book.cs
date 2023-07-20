using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic.Models
{
    internal class Book
    {
        public string name;
        public string author;
        public int pageCount;

        public void ShowAdvert()
        {
            int a = 5;
            string b = "Welcome";

            Console.WriteLine("Avertisment" +" "+ a + b);
        }
    }
}
