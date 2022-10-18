using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowBasicDemo
{
    public class CalculatorApplication
    {
        public int Add(int i,int j)
        {
            return i + j;
        }
        public int Subtract(int i ,int j)
        {
            return i - j;
        }
        public int Multiply(int i,int j)
        {
            return i * j;
        }
        public double Divide(double i,int j)
        {
            // return  j !=0 ? 0: i/j ;
            return j != 0 ? Math.Round(i / j, 2) : 0;
        }
        public double Sqrt(double i )
        {
            return i != 0 ? Math.Round(Math.Sqrt(i), 2) : 0;
        }
    }
}
