using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace ExampleProject
{

  
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>() { 1,2,3};
           
            IEnumerable<int> list2 = list.Take(10);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
        }

    }
}