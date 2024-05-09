using System;

namespace challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego de las adivinanzas");
            Console.WriteLine("Estoy pensando en un número entre el 1 y el 100");


            int numero = GenerarNumero();
            int i = 0;
            string mensaje = "¡Perdiste! El número correcto es: " + numero;

            while(i < 10)
            {
                Console.WriteLine("Intento " + (i + 1) + " - Ingresa un número: ");
                if(Jugar(numero, i))
                {
                    mensaje = "¡Felicidades! Has adivinado el número correcto en " + i + " intentos.";
                    break;
                }
                i++;
            }

            Console.WriteLine(mensaje);

        }
        public static int GenerarNumero()
        {
            int numero = 0;

            Random rnd = new Random();

            numero = rnd.Next(1, 100);

            return numero;
        }

        public static bool Jugar(int numero, int intento)
        {
            bool adivino = false;

            int numeroIngresado = Convert.ToInt32(Console.ReadLine());

            if(numeroIngresado == numero)
            {
                adivino = true;
            }
            else
            {
                if(numeroIngresado > numero)
                {
                    Console.WriteLine("El número que estoy pensando es menor. Te quedan " + (9 - intento) + " intentos.");
                }
                else
                {
                    Console.WriteLine("El número que estoy pensando es mayor. Te quedan " + (9 - intento) + " intentos.");
                }
            }
            

            return adivino;
        }
    }
}
