using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abstracción;
using BE;
using Mapper;


namespace BLL
{
    public class BLL_Mozo : BLL_Empleado, IGestionable<BE_Mozo>
    {
        MPP_Mozo oMPP_Mozo;

        public BLL_Mozo()
        {
            oMPP_Mozo = new MPP_Mozo();
        }
        public bool Baja(BE_Mozo Objeto)
        {
            return oMPP_Mozo.Baja(Objeto);
        }

        public bool Guardar(BE_Mozo Objeto)
        {
            return oMPP_Mozo.Guardar(Objeto);
        }

        public List<BE_Mozo> Listar()
        {
            return oMPP_Mozo.Listar();
        }

        public BE_Mozo ListarObjeto(BE_Mozo Objeto)
        {
            throw new NotImplementedException();
        }

    }
}
