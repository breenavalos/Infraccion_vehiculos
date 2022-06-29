using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public abstract class Tipo_Infraccion
    {
        private int id_tipo;
        private string tipo_detalle;

        //tipo detalle identifica : Semaforo en rojo, Borracho etc.
        //id_tipo : categoriza su gravedad. 

        public Tipo_Infraccion(int id_tipo, string tipo_detalle)
        {
            this.id_tipo = id_tipo;
            this.tipo_detalle = tipo_detalle;
        }

    }
}
