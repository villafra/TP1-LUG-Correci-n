using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracción;

namespace BE
{
    public class BE_Mesa:IEntidable
    {
        public int Codigo { get; set; }
        public int NroDeMesa { get; set; }
        public int Capacidad { get; set; }
        public string Estado { get; set; }
        public int CantidadComensales { get; set; }

        public override string ToString()
        {
            return NroDeMesa.ToString();
        }
    }
}
