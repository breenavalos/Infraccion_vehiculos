﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    internal class Pago
    {
        private int codigo;
        private List<Registro_De_Infraccion> Infracciones_a_pagar;
        private float monto_total;
        private Tarjeta unaTarjeta;
   

        public Pago(int codigo, Tarjeta unaTarjeta,float monto_total)
        {
            this.codigo = codigo;
            this.unaTarjeta = unaTarjeta;
            this.monto_total = monto_total;
        }




    }
}
