using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Conexión;
using Abstracción;
using System.Data;

namespace Mapper
{
    public class MPP_Mozo : MPP_Empleado, IGestionable<BE_Mozo>
    {
        ClsDataBase Acceso;
        public bool Baja(BE_Mozo oBE_Mozo)
        {
            string query = @"Delete from Mozo where [Legajo]=" + oBE_Mozo.Codigo;
            Acceso = new ClsDataBase();
            return Acceso.EscribirTransaction(query);
        }

        public bool Guardar(BE_Mozo Mozo)
        {
            string query;

            if (Mozo.Codigo != 0)
            {
                query = @"Update Mozo set DNI= " + Mozo.DNI + ", Nombre= '" + Mozo.Nombre + "', Apellido= '" + Mozo.Apellido + "', [Fecha Nacimiento]= '" + Mozo.FechaNacimiento + "', [Codigo_Turno]= " + Mozo.Turno.Codigo + ", Puntuacion= " + Mozo.Puntuación + "where [Legajo]= " + Mozo.Codigo;
            }
            else
            {
                query = @"Insert into Mozo (DNI, Nombre, Apellido, [Fecha Nacimiento], [Codigo_Turno]) values (" + Mozo.DNI + ",'" + Mozo.Nombre + "','" + Mozo.Apellido + "','" + Mozo.FechaNacimiento.ToString("yyyy-MM-dd") + "'," + Mozo.Turno.Codigo + ")";
            }
            Acceso = new ClsDataBase();
            return Acceso.EscribirTransaction(query);
        }

        public List<BE_Mozo> Listar()
        {
            Acceso = new ClsDataBase();
            DataSet Ds;
            string query = @"Select * from Mozo,Turno where Mozo.Codigo_Turno=Turno.Codigo_Turno";
            Ds = Acceso.DevolverListado(query);
            List<BE_Mozo> ListadeMozos = new List<BE_Mozo>();

            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach(DataRow row in Ds.Tables[0].Rows)
                {
                    BE_Mozo Mozo = new BE_Mozo();
                    Mozo.Codigo = Convert.ToInt32(row[0].ToString());
                    Mozo.DNI = Convert.ToInt32(row[1].ToString());
                    Mozo.Nombre = row[2].ToString();
                    Mozo.Apellido = row[3].ToString();
                    Mozo.FechaNacimiento = Convert.ToDateTime(row[4].ToString());
                    Mozo.Edad = Mozo.DevolverEdad();
                    BE_Turno oBE_Turno = new BE_Turno();
                    oBE_Turno.Codigo = Convert.ToInt32(row[7].ToString());
                    oBE_Turno.NombreTurno = row[8].ToString();
                    oBE_Turno.HoraInicio = Convert.ToDateTime(row[9].ToString());
                    oBE_Turno.HoraFin = Convert.ToDateTime(row[10].ToString());
                    Mozo.Turno = oBE_Turno;
                    ListadeMozos.Add(Mozo);
                }
            }
            else
            {
                ListadeMozos = null;
            }
            return ListadeMozos;
        }

        public BE_Mozo ListarObjeto(BE_Mozo Objeto)
        {
            throw new NotImplementedException();
        }

    }
}
