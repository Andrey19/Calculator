using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yyy
{
   public static class CalculatorFactory
    {
       public static Calculator Create(string name) 
       {
           switch (name) 
           {
               case "/": return new Dev();          
           
               case "*": return new Mov();
           
               case "+": return new Sum();
      
               case "-": return new Sup();

               case "Sin": return new Sin();

               case "Cos": return new Cos();

               case "Fac":
               case "!":
                           return new Fac();

               case "Sgr": return new Sgr();

               case "%": return new Proc();

               default: throw new Exception("неизвестная команда");
           }

       }
    }
}
