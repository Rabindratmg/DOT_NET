using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEg
{
    internal class WithoutUsingDelegate
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine("sum={0}", a + b);

        }
        public void Welcome(string message)
        {
            Console.WriteLine(message);
        }
        
        public void ClassInstance()
        {
            WithoutUsingDelegate withoutUsingDelegate = new WithoutUsingDelegate();
            withoutUsingDelegate.Sum(5, 10);
            withoutUsingDelegate.Welcome("Hi how are you?");


        }


    }


}
