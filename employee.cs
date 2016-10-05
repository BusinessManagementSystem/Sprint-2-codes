using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Employee
    {
        string Firstname, Lastname;
        int EmplID;
        int logintime;
        int logoutime;
        string loginname;
        int password;
        int tardy;
        int payrate;
        string[] days= { "mon", "tue", "wed", "thu", "fri", "sat", "sun" };
        static void Main(string[] args)
        {


                Console.WriteLine("this is employee class");
                Console.ReadLine();
        }
    }
}
