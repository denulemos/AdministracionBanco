using System;
using System.Collections.Generic;

namespace EjercicioBanco
{
    // Clase abstracta , clase que no se puede instanciar, solo define una actividad, no se puede usar
   // cuenta directamente, si no caja de ahorro y cuenta corriente

  public abstract class Cuenta
    {
        public decimal saldo {get; set;}
        public long Numero {get; set;}

        public List <Persona> Titular {get; set;}
        public List <Operacion> Operaciones {get; set;}
        public Cuenta()

        {
            this.saldo = 0;
            this.Titular = new List <Persona>();
            this.Operaciones = new List <Operacion>();

        }

        public Cuenta (long numero)
        {
this.Numero = numero;
            this.saldo = 0;
            this.Titular = new List<Persona>();
            this.Operaciones = new List<Operacion>();
        }


        /// <summary>
        /// Se retira dinero de la cuenta con este metodo
        /// </summary>
        /// <param name="cantidad"></param>
        /// <returns></returns>

        public bool RetirarDinero(decimal cantidad)

     {
             if (saldo >= cantidad)
             {
                 this.saldo -= cantidad;
                 this.Operaciones.Add(new Operacion { Moonto = cantidad,
                                                      Fecha  = DateTime.Now,
                                                      Tipo = "Extraccion"});

                 return true;
             }

             return false;
       }
           

    public bool DepositarDinero(decimal cantidad)
        {
            this.saldo += cantidad;
            this.Operaciones.Add( new Operacion { Moonto = cantidad,
                                                  Fecha = DateTime.Now,
                                                Tipo = "Deposito" });
            return true;
        }
    
    public void MostrarOperacionesRealizadas()
    {
        foreach(Operacion Operacion in this.Operaciones)
        {
            Console.WriteLine("{0} {1} : {2} ",
            Operacion.Fecha.ToString ("yyyy/mm/dd HH:mm:ss"),
            Operacion.Tipo,
            Operacion.Moonto.ToString ("C2")
         
            );
        }
    }
    }

}

