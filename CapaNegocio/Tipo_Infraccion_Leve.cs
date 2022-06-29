using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Tipo_Infraccion_Leve : Tipo_Infraccion
    {
        private int descuento_veinte_dias;
        private int descuento_diez_dias;
        public Tipo_Infraccion_Leve(int id_tipo, string tipo_detalle) : base(id_tipo, tipo_detalle)
        {
            this.descuento_veinte_dias = 25;
            this.descuento_diez_dias = 15;
        }

    
    }
}
