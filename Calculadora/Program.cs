using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            var resultado = 0.0;
            double numero1, numero2;
            bool modo = true;

            
            try
            {
                do
                {
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("|          MENU DE OPERACIONES            |");
                    Console.WriteLine("___________________________________________");
                    Console.WriteLine("___________________________________________");
                    Console.WriteLine("|          Ingresa 1: SUMA                |");
                    Console.WriteLine("|          Ingresa 2: RESTA               |");
                    Console.WriteLine("|          Ingresa 3: MULTIPLICACIÓN      |");
                    Console.WriteLine("|          Ingresa 4: DIVISIÓN            |");
                    Console.WriteLine("|          Ingresa 0: APAGAR CALCULADORA  |");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Ingrese una opción: ");
                    opcion = Int32.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 0:
                            modo = false;
                            break;
                        case 1:
                            Console.WriteLine("Ingresa el primer numero: ");
                            numero1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa el segundo numero:");
                            numero2 = double.Parse(Console.ReadLine());
                            resultado = numero1 + numero2;
                            break;
                        case 2:
                            Console.WriteLine("Ingresa el primer numero: ");
                            numero1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa el segundo numero:");
                            numero2 = double.Parse(Console.ReadLine());
                            resultado = numero1 - numero2;
                            break;
                        case 3:
                            Console.WriteLine("Ingresa el primer numero: ");
                            numero1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa el segundo numero:");
                            numero2 = double.Parse(Console.ReadLine());
                            resultado = numero1 * numero2;
                            break;
                        case 4:
                            Console.WriteLine("Ingresa el primer numero: ");
                            numero1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa el segundo numero:");
                            numero2 = double.Parse(Console.ReadLine());
                            resultado = numero1 / numero2;
                            break;
                        default:
                            Console.WriteLine("Opción no disponible.");
                            break;
                    }
                    Console.WriteLine($"Resultado: {resultado}");
                } while (modo == true);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
            finally 
            {
                Console.WriteLine("Programa finalizado.");
            }
        }
    }
}