using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int a = 123;
            string b = "이";
            string c = "이dsfjlskfj";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("1");
            Console.ReadKey();
            Console.WriteLine("");

            A tv01 = new A();
            A tv02 = new A();
            tv01.a = 123;
            tv02.a = 789;
            Console.WriteLine(tv01.a);
            Console.WriteLine(tv02.a);

       

            Console.ReadKey();



        }
    }

    class A
    {
        public int a;
        public string b = "가";

        

    }
}
