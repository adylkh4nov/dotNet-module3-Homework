using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_module3_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Homework hw = new Homework();
            //int[] arr = hw.example1();
            string str = "//asfasfass ";
            hw.example12(ref str);
            Console.WriteLine(hw.example17("11 12 13 14    "));
            /*for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }*/
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
