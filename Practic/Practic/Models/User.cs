using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practic.Models
{
    internal class User
    {

        public User()
        {
            
        }

        public string username;

        public User(string username)
        {
            this.username = username;
        }
       
    }

}