using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Method_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();
            myAccount.getBalance();
            Console.ReadKey();
        }
    }
}
