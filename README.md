# Infraccion_vehiculos
         SOLUCION : 2 INTERFACES 
            1- ADMINISTRADOR (objetivo registrar,y ver infracciones)
            2- TITULAR (objetivo ver infracciones, y pagar)
         
       
         1- 
            A) INTERFAZ 1
            En base a una matricula ingresada por el usuario, buscar si se encuentra en la lista "infracciones_a_pagar"
            Si esta -> le lista las infracciones a pagar (INTERFAZ 2)
            Si no esta -> cartel "no tiene infracciones a pagar" (no debe nada)
            
            B) INTERFAZ 2
            El usuario ve la lista a detalle de infracciones a pagar y puede escoger 1 o mas para efectuar el pago. 
            Selecciona pagar (INTERFAZ 3)

            **Ver si en tiempo real se puede ir calculando el monto total**
            

            C) INTERFAZ 3
            El usuario ingresa datos de tarjeta (como el pago de cuotas de la facu). Selecciona pagar. (INTERFAZ 4)

            **Ver manejo de errores en ingreso de datos**

            D) INTERFAZ 4
            Cartel pago exitoso/no exitoso.
            
       
        2-
            A) INTERFAZ 1
            Acciones:
                -Ver infracciones a pagar. (INTERFAZ 2)
                -Ver infracciones pagadas. (INTERFAZ 3)
                -Registrar una infraccion. (INTERFAZ 4)
                -Agregar un tipo de infraccion o modificar el descuento del tipo de infraccion (INTERFAZ 5)
                ****EXTRA**** -Buscar por vehiculo si tiene alguna infraccion o si pago alguna infraccion.
            
            B) INTERFAZ 2
                Listar infracciones a pagar
            
            C) INTERFAZ 3
                Listar infracciones pagadas.

            D) INTERFAZ 4
            
            Se listan los tipos de infraciones 
            El usario selecciona 1 tipo de infraccion e ingresa num matricula , num de dni , fecha de suceso.
            Se genera la infraccion.
            Se añade a lista de infracciones a pagar.

            E)
            Se listan los tipos de infraciones.
            Se selecciona 1 para modificar. (Solo se puede modificar el descuento por default ) Si quiere cambiar de gravedad, que lo elimine y lo vuelva a crear.
            o 
            Se agrega uno nuevo. 
            MANEJAR BORRACHO - ID 09 - SELECCIONA LEVE O GRAVE.
           

