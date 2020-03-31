using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascota
{
    public class Mascota
    {
        private string nombre;
        private string especie;
        private int edad;
        private string dueño;
        private int cantVacunas;
        private int cantOperaciones;

        public Mascota (string nombre, string especie, int edad, string dueño)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.edad = edad;
            this.dueño = dueño;
            this.cantVacunas = 0;
            this.cantOperaciones = 0;

        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set { this.nombre = value; }
        }

        public string Especie
        {
            get
            {
                return this.especie;
            }
            set { this.especie = value; }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
            set { this.edad = value; }
        }

        public string Dueño
        {
            get
            {
                return this.dueño;
            }
            set { this.dueño = value; }
        }

        public void mostrarMascota()
        {
            Console.WriteLine("Nombre: " + Nombre + " Especie: " + Especie + " Edad: " + Edad + " Dueño: " + Dueño);
        }

        public void dormir()
        {
            Console.WriteLine(Nombre + " esta durmiendo");
        }

        public void comer()
        {
            Console.WriteLine(Nombre + " esta comiendo");
        }

        public void volar()
        {
            if (especie.ToLower() == "pajaro")
            {
                Console.WriteLine(Nombre + " esta volando");
            } else
            {
                Console.WriteLine(Nombre + " no puede volar");
            }
        }

        public void vacunar()
        {
            cantVacunas = cantVacunas + 1;
            Console.WriteLine(Nombre + " recibio una vacuna." + " Cantidad actual de vacunas: " + cantVacunas);
        }

        public void operar()
        {
            cantOperaciones = cantOperaciones + 1;
            Console.WriteLine(Nombre + " ha sido operado." + " Cantidad actual de operaciones: " + cantOperaciones);
        }





    }
}
