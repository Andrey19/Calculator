using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yyy
{
    public class Fac:Calculator
    {
        public override double Calc(double a, double b)
        {
            double res=1;

            for (int c=(int)a;c>=1;c--)
            {
                res*=c;
            }
       
                
            return res;
        }
    }
}
