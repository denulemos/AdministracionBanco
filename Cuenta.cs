using System;
using System.Collections.Generic;

namespace EjercicioBanco
{
    class Cuenta
    {
        public decimal saldo {get; set;}
        public long Numero {get; set;}

        public List <Persona> Titular {get; set;}

        public Cuenta()

        {
            this.saldo = 0;
            this.Titular = new List <Persona>();

        }

        public Cuenta (long numero)
        {
            
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
                 return true;
             }

             return false;
       }
           

    public bool DepositarDinero(decimal cantidad)
        {
            this.saldo += cantidad;
            return true;
        }

    }

}

