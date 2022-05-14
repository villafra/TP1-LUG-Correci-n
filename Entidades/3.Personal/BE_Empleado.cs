using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracción;

namespace BE
{
    public class BE_Empleado:IEntidable
    {
        public int Codigo { get; set; }
        public long DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public BE_Turno Turno { get; set; }

        public int DevolverEdad()
        {
            int edad = DateTime.Now.Year - FechaNacimiento.Year;
            if (DateTime.Now.Month < FechaNacimiento.Month)
            {
                edad -= 1;
            }
            if (FechaNacimiento.Month == DateTime.Now.Month && DateTime.Now.Day < FechaNacimiento.Day)
            {
                edad -= 1;
            }
            return edad;
        }
    }
}
