using System;
using System.Linq;
using System.Collections.Generic;

namespace System
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var setClass = new SetClass();

            setClass.GetSet();
        }
    }

    class SetClass
    {
        List<int> first = new List<int> {2, 3, 4, 5, 6, 7, 8, 9};
        List<int> second = new List<int> {1, 2, 3, 4, 10, 11, 12};

        public void GetSet()
        {
            // Union()
            // Get the union set
            IEnumerable<int> union = first.Union(second);
            foreach (int num in union)
                Console.Write("{0} ", num);
            Console.WriteLine();

            // Except()
            // Get the difference set
            IEnumerable<int> except = first.Except(second);
            foreach (int num in except)
                Console.Write("{0} ", num);
            Console.WriteLine();

            // Intersect()
            // Get the product set
            IEnumerable<int> intersect = first.Intersect(second);
            foreach (int num in intersect)
                Console.Write("{0} ", num);
            Console.WriteLine();
        }
    }
}