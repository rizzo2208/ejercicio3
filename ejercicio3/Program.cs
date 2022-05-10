using ejercicio3.clases;
using System;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Nombre completo: ");
            string nombre = Console.ReadLine();
            string apellido = Console.ReadLine();


            Titular titular = new Titular(nombre, apellido);
            Cuenta cuenta = new Cuenta(titular);

            double cantDin;
            double monto;
            int opcion;
            do
            {

                do
                {
                    try
                    {
                        Console.WriteLine("---------------------menu------------------");
                        Console.WriteLine("para ingresar dinero opcion 1");
                        Console.WriteLine("para retirar dinero opcion 2");
                        Console.WriteLine("para retirarse opcion 0");

                        opcion = int.Parse(Console.ReadLine());
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                        opcion = 3;
                    }
                    Console.ReadKey();
                    Console.Clear();

                } while (opcion < 0 || opcion > 2);

                switch (opcion)
                {
                    case 1:
                        bool flag = true;

                        do
                        {
                            try
                            {
                                Console.WriteLine("Por favor ingrese el monto a acreditar:");
                                monto =double.Parse(Console.ReadLine());
                                
                                cantDin = cuenta.ingresarDinero(monto);
                                Console.WriteLine("Deposito\nEstado de la cuenta: " + cantDin);

                                flag = true;
                            }
                            catch (Exception error)
                            {
                                Console.WriteLine(error.Message);
                                flag = false;
                            }
                            Console.Clear();
                        } while (flag == false);

                        Console.ReadKey();
                        break;
                    //-------------------------------------------

                    case 2:

                        do
                        {
                            try
                            {
                                Console.WriteLine("Por favor ingrese el monto a retirar:");
                                monto = double.Parse(Console.ReadLine());
                              
                                cantDin = cuenta.retirarDinero(monto);
                                Console.WriteLine("Deposito\nEstado de la cuenta: " + cantDin);

                                flag = true;
                            }
                            catch (Exception error)
                            {
                                Console.WriteLine(error.Message);
                                flag = false;


                            }
                        } while (flag == false);

                        Console.ReadKey();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (opcion != 0);

        }
    }
}
