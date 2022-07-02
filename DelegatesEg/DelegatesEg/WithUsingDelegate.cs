using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEg
{
    public delegate void SumDelegate(int a, int b);

    //public delegate void DiffDelegate(int a, int b);

    public delegate void WelcomeDelegate(string message);

    internal class WithUsingDelegate
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine("sum={0}", a + b);

        }

        public void Diff(int a, int b)
        {
            Console.WriteLine("Diff={0}", a - b);
        }
        public void Welcome(string message)
        {
            Console.WriteLine(message);
        }

       
        public void CallMethod()
        {
            SumDelegate sumDelegate = new SumDelegate(Sum);
            sumDelegate += Diff;
            sumDelegate.Invoke(15, 10);

            sumDelegate -= Diff;
            sumDelegate.Invoke(15, 10);

            WelcomeDelegate welcomeDelegate = new WelcomeDelegate(Welcome);
            welcomeDelegate.Invoke("I am fine thank you.");
        }

    }
}
