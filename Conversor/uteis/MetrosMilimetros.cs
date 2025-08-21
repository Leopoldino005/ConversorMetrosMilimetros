using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor.uteis
{
    public class MetrosMilimetros
    {
        //Independente da instância 
        public static double Conversor(double metros) //Com escopo de classe
        {
            return metros * 1000;
        }
    }
}
