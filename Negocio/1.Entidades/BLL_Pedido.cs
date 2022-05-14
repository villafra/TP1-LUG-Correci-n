using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Mapper;
using Abstracción;

namespace BLL
{
    public class BLL_Pedido : IGestionable<BE_Pedido>
    {
        MPP_Pedido oMPP_Pedido;

        public BLL_Pedido()
        {
            oMPP_Pedido = new MPP_Pedido();
        }


        public bool Baja(BE_Pedido Pedido)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE_Pedido Pedido)
        {
            throw new NotImplementedException();
        }

        public List<BE_Pedido> Listar()
        {
            throw new NotImplementedException();
        }

        public BE_Pedido ListarObjeto(BE_Pedido Pedido)
        {
            throw new NotImplementedException();
        }
    }
}
