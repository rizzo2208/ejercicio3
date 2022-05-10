using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3.clases
{
    internal class Cuenta
    {
        private Titular titular;
        private double cantidad;

        public Cuenta(Titular titular)
        {
            this.titular = titular;
        }
        public Cuenta(Titular titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Nombre { get => Nombre; set => Nombre = value; }
        public string Apellido { get => Apellido; set => Apellido = value; }

        //-----------------------------METODOS--------------------------------------------

        //MUESTRA LA CANTIDAD QUE HAY EN LA CUENTA
        public override string ToString()
        {
            return "Datos de la cuenta: \n Titular: " + titular.ToString() + "\tCantidad: " + cantidad;
        }

        //INGRESA DINERO
        public double ingresarDinero(double monto)
        {
            try
            {
                if (monto > 0)
                {
                    this.cantidad += monto;
                }
                else
                {
                    Console.WriteLine("No has ingresado dinero.");
                }
            }
            catch (Exception)
            {
                Console.Write("Ingrese un valor numerico.");
            }
            return this.cantidad;
        }

        //RETIRA DINERO
        public double retirarDinero(double monto)
        {
            try
            {
                if (this.cantidad >= 0)
                {
                    this.cantidad -= monto;
                }
                else
                {
                    Console.WriteLine("Monto Insuficiente.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ingrese un valor numerico.");
            }
            return this.cantidad;
        }
    }
}
