using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal_Derick
{
    public class Smartphone : Dispositivo
    {
        public string SistemaOperativo { get; set; }
        public int NumCamaras { get; set; }

        public Smartphone()
        {
            SistemaOperativo = string.Empty;
            NumCamaras = 0;
        }
    }
}
