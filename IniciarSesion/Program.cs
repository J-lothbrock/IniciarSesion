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

            Console.WriteLine("Ingresa clave:");
            string clave = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Analizando datos...");

            Thread.Sleep(3000);

            if (usuario == "Josue2314" && clave == "josue2314")
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
            int opcionSeleccionada;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sesion Exitosa\n");
            Console.ResetColor();

            if (hr >= 0 && hr < 12)
            {
                Console.WriteLine("Buenos dias " + us + "\n");
            }
            else if (hr >= 12 && hr < 19)
            {
                Console.WriteLine("Buenas tardes " + us + "\n");
            }
            else if (hr >= 19 && hr < 23)
            {
                Console.WriteLine("Buenas noches " + us + "\n");
            }

        repeat_2:
            
            Console.WriteLine("Elige una Opcion \n" +
                "1. Sumar" +
                " 2. Restar" +
                " 3. Multiplicar" +
                " 4. Dividir");
            try
            {
                opcionSeleccionada = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Thread.Sleep(100);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Por favor, ingrese unos de los numeros que estan en pantalla");
                Console.ResetColor();

                goto repeat_2;
            }

            if (opcionSeleccionada != 1)
            {
                if (opcionSeleccionada != 2)
                {
                    if (opcionSeleccionada != 3)
                    {
                        if (opcionSeleccionada != 4)
                        {
                            Console.Clear();
                            Thread.Sleep(100);

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Lo sentimos, esta opcion no existe.");
                            Console.ResetColor();

                            
                            goto repeat_2;

                        }
                    }
                }
            }

            switch(opcionSeleccionada)
            {
                case 1:
                    Suma();
                    break;

                case 2:
                    Resta();
                    break;

                case 3:
                    Multiplicacion();
                    break;

                case 4:
                    Division();
                    break;
            }


        }

        private static void Suma()
        {
            decimal num1;
            decimal num2;

         repeat_3:

            try
            {
                Console.WriteLine("Ingrese el primer numero:");
                num1 = decimal.Parse(Console.ReadLine());

            }
            catch (Exception)
            {

                Console.Clear();
                Thread.Sleep(100);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Este no es numero, por favor ingrese un numero");
                Console.ResetColor();

                goto repeat_3;
            }

            repeat_4:
            try
            {
                Console.WriteLine("Ingrese el segundo valor:");
                num2 = decimal.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.Clear();
                Thread.Sleep(100);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Este no es numero, por favor ingrese un numero");
                Console.ResetColor();

                goto repeat_4;
            }

            decimal suma = num1 + num2;

            Console.WriteLine("El resultado de la suma es " + suma);
        }

        private static void Resta()
        {
            decimal num1;
            decimal num2;

            repeat_5:
            try
            {
                Console.WriteLine("Ingresae el primer numero:");
                num1 = decimal.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.Clear();
                Thread.Sleep(100);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Este no es numero, por favor ingrese un numero");
                Console.ResetColor();

                goto repeat_5;
            }

            repeat_6:
            try
            {
                Console.WriteLine("Ingrese el segundo numero ");
                num2 = decimal.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Clear();
                Thread.Sleep(100);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Este no es numero, por favor ingrese un numero");
                Console.ResetColor();

                goto repeat_6;

            }

            decimal resta = num1 - num2;

            Console.WriteLine("El resultado de tu resta es " + resta);


        }

        private static void Multiplicacion()
        {
            decimal num1;
            decimal num2;

            try
            {
                Console.WriteLine("Ingrese el primer numero:");
                num1 = decimal.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Clear();
                Thread.Sleep(100);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Este no es numero, por favor ingrese un numero");
                Console.ResetColor();

            }

            try
            {
                Console.WriteLine("Ingrese el segundo numero:");
                num2 = decimal.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.Clear();
                Thread.Sleep(100);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Este no es numero, por favor ingrese un numero");
                Console.ResetColor();
            }

        }

        private static void Division()
        {

        }

    }
}

