using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructor.Models
{
    internal class Account
    {
        public string userName;
        public string password;


        public void Login(string username, string password)
        {
            if (username == "iskender_xeyyam" && password == "xeyyam111")
            {
                Console.WriteLine("Login Succesd");
            }
            else
            {
                Console.WriteLine("Email or password is wrong");
            }
        }
    }
}