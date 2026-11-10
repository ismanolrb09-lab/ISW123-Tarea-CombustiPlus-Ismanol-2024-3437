using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombustiPlus
{
    public class Despacho
    {
        public int Numero {  get; set; }
        public string Placa { get; set; }
        public string Combustible { get; set; }
        public decimal Galones { get; set; }
        public string Pago { get; set; }
        public decimal Total { get; set; }

    }
}
