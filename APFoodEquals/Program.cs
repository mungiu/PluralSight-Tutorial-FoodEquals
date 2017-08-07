using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APFoodEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = { "apple", "orange", "pineapple" };
            string[] arr2 = { "apple", "pear", "pineapple" };

            //Console.WriteLine(arr1 == arr2);
            //Console.WriteLine(arr1.Equals(arr2));

            //struct equality
            //1 - casting array to an interface that allows test for struct equality
            //2 - testing for equality with Equals() using equality comparer "StringComparer"
            var arrayEq = (IStructuralEquatable)arr1;
            bool structEqual = arrayEq.Equals(arr2, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(structEqual);

            //struct comparison
            var arrayComp = (IStructuralComparable)arr1;
            int structComp = arrayComp.CompareTo(arr2, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(structComp);
        }

    }
}
