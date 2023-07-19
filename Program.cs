using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lophinhchunhat
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the width: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height: ");
            double height = double.Parse(Console.ReadLine());

            HCN hcn1 = new HCN(width, height);

            Console.WriteLine("YOUR HCN \n " + hcn1.Display());
            Console.WriteLine("chu vi la \n " + hcn1.GetPerimeter());
            Console.WriteLine("dien tich la \n " + hcn1.GetArea());

        }
    }
}
