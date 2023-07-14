using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruits_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al=new ArrayList()
            {
                "apple",
                "banana",
                "cherry",
                "date",
                "elderberry"
            };
            Console.WriteLine("total number of Elements in the ArrayList:\t"+al.Count);
            Console.WriteLine("Enter for Searching item");
            string searchitem=Console.ReadLine();
            int index=al.IndexOf(searchitem);
            if(index==-1)
            {
                Console.WriteLine($"No such item {searchitem} is found");
            }
            else
            {
                Console.WriteLine(searchitem);
            }
            Console.WriteLine("******************************");
            al.Insert(1,"fig");
            al.Remove("banana");
            Console.WriteLine("Elements in the ArrayList");
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
