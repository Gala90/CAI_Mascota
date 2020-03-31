using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascota
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota miMascota1 = new Mascota("Max", "Perro", 4, "Lola");

            Mascota miMascota2 = new Mascota("Candy", "Gato", 13, "Gala");

            Mascota miMascota3 = new Mascota("Tweety", "Pajaro", 3, "Gala");

            miMascota1.mostrarMascota();

            miMascota1.comer();

            miMascota2.dormir();

            miMascota1.dormir();

            miMascota2.vacunar();

            miMascota1.volar();

            miMascota2.volar();

            miMascota3.volar();

            miMascota1.operar();

            miMascota1.vacunar();

            miMascota2.vacunar();





            Console.ReadKey();

        }
    }
}
