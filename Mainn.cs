using System;
using System.Collections.Generic;
namespace EjercicioBanco
{
    class Mainn
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("");
            Console.WriteLine("1- Crear Cuenta nueva");
            Console.WriteLine("2- Ver saldo de tu cuenta");
            Console.WriteLine("3- Retirar dinero (Restar Saldo)");
            Console.WriteLine("4- Ingresar dinero (Sumar Saldo)");
            Console.WriteLine ("5 - Salir");

            int opcion = int.Parse(Console.ReadLine());

            if (opcion==1)
            {
                List<Titular> listaPersonas = new List<Titular>();
                List <Cuenta> listacuenta = new List <Cuenta>();
                 Titular titular = new Titular();

                 Console.WriteLine("Ingrese DNI");
                    titular.dni =long.Parse( Console.ReadLine());

                Console.WriteLine("Ingrese Nombre");
                    titular.nombre =  Console.ReadLine();
                Console.WriteLine("Ingrese Apellido");
                    titular.apellido = Console.ReadLine();

                       Cuenta saldo = new Cuenta();

                Console.WriteLine("Ingrese Saldo Inicial");
                    saldo.saldo = long.Parse (Console.ReadLine());

                    listaPersonas.Add(titular);
                Cuenta cuenta = null;
                listacuenta.Add(cuenta);

                

                Console.WriteLine("¿Quiere agregar un segundo titular? s/n");
                string opcionn = Console.ReadLine();
                
             while(!opcionn.ToLower().Equals("n"))
                 {
                      Console.WriteLine("Ingrese DNI");
                    titular.dni2 =long.Parse( Console.ReadLine());

                Console.WriteLine("Ingrese Nombre");
                    titular.nombre2 =  Console.ReadLine();
                Console.WriteLine("Ingrese Apellido");
                    titular.apellido2 = Console.ReadLine();

                break;
                 }
                Console.WriteLine("Cuenta Creada!");



            }
            if (opcion == 2)
            {
                
            }
            if (opcion == 3)
            {

            }
            if (opcion == 4)
            {

            }
            if (opcion == 5)
            {
                Console.WriteLine("Gracias por usar el sistema! Aprete cualquier tecla para salir");
                Console.ReadKey();
            }

            
            




        }
    }
}
