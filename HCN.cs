using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lophinhchunhat
{
    public class HCN
    {
        double width;
        double height;

        public HCN(){ }
        public HCN(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double GetArea()
        {
            return this.width * this.height;
        }
        public double GetPerimeter()
        {
            return (this.width + this.height)*2;
        }
        public string Display()
        {
            return "HCN{" + "width=" + width + ", height=" + height + "}";
        }
    }
}
