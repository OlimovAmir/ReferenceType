using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceType
{
    class Types
    {
        static void Foo(int a)
        {
            a = 5;
        }
        static void Bar(int[] arr)
        {
            arr[0] = 25;
        }
        static void Main(string[] args)
        {
            int a = 10;
            int[] arr = new int [10];
            int[] b = new int[1];
            Random random = new Random();
            Bar(b);
            Foo(a);
            Console.WriteLine(a);
            Console.WriteLine(b[0]);
        }
    }
}
