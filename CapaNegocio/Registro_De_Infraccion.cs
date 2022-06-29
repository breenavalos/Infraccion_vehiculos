using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Registro_De_Infraccion
    {

        private Vehiculo unVehiculo;
        private Infraccion unaInfraccion;
        private DateTime fecha_de_suceso;
        private DateTime fecha_de_vencimiento;

        public Registro_De_Infraccion(Vehiculo unVehiculo, Infraccion unaInfraccion, DateTime fecha_de_suceso) 
        {
            this.unVehiculo = unVehiculo;
            this.unaInfraccion = unaInfraccion;
            this.fecha_de_suceso = fecha_de_suceso;
           // this.fecha_de_vencimiento = fecha_de_suceso + 30; *ver*
        }





    }
}
