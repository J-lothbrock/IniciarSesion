using System;
using System.Threading;

namespace IniciarSesion
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour;

            repeat:
            Console.WriteLine("Ingresa usuario:");
            string usuario = Console.ReadLine();

            Console.WriteLine("Ingresa clave");
            string clave = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Analizando datos...");

            Thread.Sleep(3000);

            if(usuario == "Josue2314" && clave == "josue2314")
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Inciando sesion...");
                Thread.Sleep(2000);

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Por favor, espere");

                Thread.Sleep(2000);

                Console.Clear();

                Inicio(usuario, hour);

            }
            else
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Los datos no coinciden, intente nuevamente \n");
                Console.ResetColor();

                goto repeat;
            }

        }

        private static void Inicio(string us, int hr)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sesion Exitosa\n");
            Console.ResetColor();

            if(hr >= 0 && hr < 12)
            {
                Console.WriteLine("Buenos dias " + us);
            }
            else if(hr >= 12 && hr < 19)
            {
                Console.WriteLine("Buenas tardes " + us);
            }
            else if(hr >= 19 && hr < 23)
            {
                Console.WriteLine("Buenas noches " + us);
            }

            


        }
    }
}
