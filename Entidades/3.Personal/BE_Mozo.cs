using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Mozo : BE_Empleado
    {
        public int Puntuación { get; set; }

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido;
        }
    }
}
