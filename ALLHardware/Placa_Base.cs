using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALLHardware
{
    class Placa_Base
    {
        public string Fabricante { get; set; }
        public string Socket { get; set; }
        public string Chipset { get; set; }
        public string MemoriaSlots { get; set; }
        public string Canales { get; set; }
        public string Formato { get; set; }
        public int Puertos { get; set; }
    }
}
