using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Tipo_Infraccion_Grave : Tipo_Infraccion
    {
        private int descuento_veinticinco_dias;

        public Tipo_Infraccion_Grave(int id_tipo,string tipo_detalle) :base(id_tipo,tipo_detalle)
        {
            this.descuento_veinticinco_dias = 20;
        }



    }
}
