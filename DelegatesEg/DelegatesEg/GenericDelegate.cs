using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEg
{
    // In generic delegate defination  is not required.
    //public delegate int DelegateSum(int a, int b);
    //public delegate void DelegateMessage(string message);
    //public delegate bool DelegateCheckOddNum(int a);
    internal class GenericDelegate
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }

        public bool CheckOddNum(int a)
        {
            if (a % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CallMethod()
        {
            Func<int, int, int> d1 = new Func<int, int, int>(Sum);
            int ans = d1.Invoke(2, 3);
            Console.WriteLine("Sum of two interger is {0}",ans);
            Action<string> d2 = new Action<string> (Message);
            d2.Invoke("Ok I am generic message");
            Predicate<int> d3 = new Predicate<int> (CheckOddNum);
            bool istrueorfalse = d3.Invoke(5);
            Console.WriteLine("Odd = {0}",istrueorfalse);
        }
    }
}
