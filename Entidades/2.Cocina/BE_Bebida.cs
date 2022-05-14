using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracción;

namespace BE
{
    public class BE_Bebida :IEntidable,IStockeable
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Presentación { get; set; }
        public decimal CostoUnitario { get; set; }
        public int Stock { get; set; }

        public void AgregarStock(int Cantidad)
        {
            Stock += Cantidad;
        }
    }
}
