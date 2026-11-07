using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHotFix
{
    public class Personaje
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        public int Nivel { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Personaje personaje = new Personaje
            {
                Nombre = "Guerrero",
                Vida = 100, 
                Ataque = 50,
                Defensa = 30,
                Nivel = 1
            };

            Console.WriteLine("Datos del personaje");
            Console.WriteLine($"Nombre: {personaje.Nombre}");
            Console.WriteLine($"Vida: {personaje.Vida}");
            Console.WriteLine($"Ataque: {personaje.Ataque}");
            Console.WriteLine($"Defensa: {personaje.Defensa}");
            Console.WriteLine($"Nivel: {personaje.Nivel}");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
