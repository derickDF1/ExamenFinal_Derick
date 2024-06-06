using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal_Derick
{
    public class Tablet : Dispositivo
    {
        public double PulgadasPantalla { get; set; }
        public bool SoporteStylus { get; set; }

        public Tablet()
        {
            PulgadasPantalla = 0;
            SoporteStylus = false;
        }
    }
}
