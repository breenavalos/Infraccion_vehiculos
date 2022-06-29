using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Infraccion
    {
        private int codigo;
        private string detalle;
        private float monto;
        private Tipo_Infraccion un_tipo_infraccion;

        public Infraccion(int codigo,string detalle, float monto, Tipo_Infraccion un_tipo_infraccion)
        {
            this.codigo = codigo;
            this.detalle = detalle;
            this.monto = monto;
            this.un_tipo_infraccion = un_tipo_infraccion;
        }


    }
}
