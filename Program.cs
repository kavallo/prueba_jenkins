using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool autenticar(string user)
        {
            if(user == "user1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
