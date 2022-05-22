using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakciLib
{
    public class KiralikEv : Ev
    {
        public double Kira { get; set; }
        public double Depozito { get; set; }

        public string PrintInfo()
        {
            return $"{base.PrintInfo()}\tKira: {this.Kira}\tDepozito: {this.Depozito}\n";
        }
    }

   
}
