using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal_Derick
{
    public class Laptop : Dispositivo
    {
        public int TamanioRam { get; set; }
        public int TamanioAlmacenamiento { get; set; }

        public Laptop()
        {
            TamanioRam = 0;
            TamanioAlmacenamiento = 0;
        }
    }
}
