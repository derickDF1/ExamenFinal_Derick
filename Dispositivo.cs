using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal_Derick
{
    public class Dispositivo
    {
        public int NumSerie { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Dispositivo()
        {
            NumSerie = 0;
            Marca = string.Empty;
            Modelo = string.Empty;
        }
    }
}
