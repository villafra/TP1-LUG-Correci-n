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
    public class MPP_Pedido : IGestionable<BE_Pedido>
    {
        ClsDataBase Acceso;
        public bool Baja(BE_Pedido Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE_Pedido Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BE_Pedido> Listar()
        {
            Acceso = new ClsDataBase();
            DataSet Ds;
            string query = @"Select * from Pedido where Activo= 1";
            Ds = Acceso.DevolverListado(query);
            List<BE_Pedido> ListadePedidos = new List<BE_Pedido>();

            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    BE_Pedido Pedido = new BE_Pedido();
                    Pedido.Codigo = Convert.ToInt32(row[0].ToString());
                    Pedido.FechaHoradeInicio = Convert.ToDateTime(row[3].ToString());
                    if (!(row[4] is DBNull))
                    {
                        Pedido.Observaciones = row[4].ToString();
                    }
                    else
                    {
                        Pedido.Observaciones = null;
                    }
                    Pedido.Monto = Convert.ToDecimal(row[5].ToString());
                    Pedido.Activo = Convert.ToBoolean(row[6].ToString());
                    Pedido.Cancelado = Convert.ToBoolean(row[7].ToString());
                    if (!(row[1] is DBNull))
                    {
                        DataSet Ds1;
                        string query1 = @"select * from Mesa where Mesa.Id_Mesa= " + Convert.ToInt32(row[1].ToString());
                        Ds1 = Acceso.DevolverListado(query1);
                        if (Ds1.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow row1 in Ds1.Tables[0].Rows)
                            {
                                BE_Mesa Mesa = new BE_Mesa();
                                Mesa.Codigo = Convert.ToInt32(row1[0].ToString());
                                Mesa.NroDeMesa = Convert.ToInt32(row1[1].ToString());
                                Mesa.Capacidad = Convert.ToInt32(row1[2].ToString());
                                Mesa.Estado = row1[3].ToString();
                                Mesa.CantidadComensales = Convert.ToInt32(row1[4].ToString());
                                Pedido.CodigoMesa = Mesa;
                            }
                        }

                    }
                    if (!(row[2] is DBNull))
                    {
                        DataSet Ds2;
                        string query2 = @"Select * from Mozo,Turno where Mozo.Codigo_Turno=Turno.Codigo_Turno and Mozo.Legajo= " + Convert.ToInt32(row[2].ToString());
                        Ds2 = Acceso.DevolverListado(query2);
                        if(Ds2.Tables[0].Rows.Count > 0)
                        {
                            foreach(DataRow row2 in Ds2.Tables[0].Rows)
                            {
                                BE_Mozo Mozo = new BE_Mozo();
                                Mozo.Codigo = Convert.ToInt32(row2[0].ToString());
                                Mozo.DNI = Convert.ToInt32(row2[1].ToString());
                                Mozo.Nombre = row2[2].ToString();
                                Mozo.Apellido = row2[3].ToString();
                                Mozo.FechaNacimiento = Convert.ToDateTime(row2[4].ToString());
                                Mozo.Edad = Mozo.DevolverEdad();
                                BE_Turno oBE_Turno = new BE_Turno();
                                oBE_Turno.Codigo = Convert.ToInt32(row2[7].ToString());
                                oBE_Turno.NombreTurno = row2[8].ToString();
                                oBE_Turno.HoraInicio = Convert.ToDateTime(row2[9].ToString());
                                oBE_Turno.HoraFin = Convert.ToDateTime(row2[10].ToString());
                                Mozo.Turno = oBE_Turno;
                                Pedido.CodigoMozo = Mozo;
                            }
                        }
                    }
                    ListadePedidos.Add(Pedido);
                }
            }
            else
            {
                ListadePedidos = null;
            }
            return ListadePedidos;
        }

        public BE_Pedido ListarObjeto(BE_Pedido Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
