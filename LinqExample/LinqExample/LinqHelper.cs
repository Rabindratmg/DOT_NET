using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    internal class LinqHelper
    {
       public void FilterList()
        {
            List <int> intNumbers = new List<int> { 1, 6, 7, 2, 3, 19, 11 };
            var result = from value in intNumbers where value % 2 == 1 orderby value ascending  select value;

            foreach(var number in result)
            {
                Console.WriteLine(number);
            }
        }


        public void MethodSyntax()
        {
            List<int> intNumbers = new List<int> { 1, 6, 7, 2, 3, 19, 11 };
            var result = intNumbers.Where(value => value > 5).OrderBy(value=> value);
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }


        }

    }
}
