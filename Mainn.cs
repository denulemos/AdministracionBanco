using System;
using System.Collections.Generic;
namespace EjercicioBanco


{
    class Mainn
    {
        static void MostrarMenu()
        {
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("");
            Console.WriteLine("1- Crear Cuenta nueva");
            Console.WriteLine("2- Ver saldo de tu cuenta");
            Console.WriteLine("3- Retirar dinero (Restar Saldo)");
            Console.WriteLine("4- Ingresar dinero (Sumar Saldo)");
            Console.WriteLine ("5 - Salir");
        }

        static void Main(string[] args)
        {
            
            MostrarMenu();
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
      {

            case 1:
            
                Persona morty = new Persona();
            morty.nombre = "Morty";
            morty.apellido = "Smith";
            morty.DNI = 38234293;
            morty.mail = "morty@mail.com";
            morty.FechaDeNacimiento = new DateTime(1990, 5, 1);
            Persona rick = new Persona();
            rick.nombre = "Rick";
            rick.apellido = "Sanchez";
            rick.DNI = 12000099;
            rick.mail = "rick@mail.com";
            rick.FechaDeNacimiento = new DateTime(1960, 5, 1);

            //creamos cuenta
            Cuenta cuenta1 = new CuentaCorriente();
            cuenta1.Numero = 231231;           
             
            //le damos la cuenta a morty
            cuenta1.Titular.Add(morty);
            cuenta1.Titular.Add(rick);
            
            Cuenta cuenta2 = new CuentaCorriente(348438);
            cuenta2.Titular.Add(morty);

            break;

            case 4:


            if(cuenta1.DepositarDinero(400))
            {
                Console.WriteLine("Operación OK");
            }
            break;


            case 3:

            if(cuenta1.RetirarDinero(200))
            {
                Console.WriteLine("Operación OK");
            }
            if(cuenta1.RetirarDinero(300))
            {
                Console.WriteLine("Operación OK");
            }
            
            cuenta1.MostrarOperacionesRealizadas();
            Console.ReadKey();

            break;
           // Thread.Sleep(2000); //Duerme el proceso por 2 segundos, entre parentesis es milisegundos

            case 2: 

            Console.WriteLine("La cuenta1 tiene un saldo: " + cuenta1.saldo);
            foreach(Persona titular in cuenta1.Titular)
            {
                Console.WriteLine("La cuenta1 tiene el titular: " + titular.NombreCompleto());
            }
            break;

   

           
                
            
            




        }
    }
    }
}
