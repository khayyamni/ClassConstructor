using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Practic.Models
{
    internal class Student
    {
        public string fullName;
        public string address;
        public int age;

        public string GetFullData()
        {
            Book book = new Book();
            book.ShowAdvert();


            return $"Fullname: {fullName}, Address: {address}, Age: {age}";
    }
}
}
