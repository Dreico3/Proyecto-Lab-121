using System;
using System.Collections.Generic;
using System.Text;

namespace Proyect8
{
    class Adoptante
    {
        private string nombre;
        private int edad;
        private string direccion;       //lugar donde viven los adoptantes
        private Mascota adoptada;

        public Adoptante()
        {
            nombre = "";
            edad = 22;
            direccion = "";
            adoptada = new Mascota();
            
        }
        public Adoptante(Mascota v)
        {
            nombre = "alfred";
            edad = 22;
            direccion = "av. matias";
            adoptada = v;
        }
        public void registroAdoptante(Mascota a)
        {
            Console.Write("Introdusca el nombre del la persona q quiere adoptar: ");
            nombre = Console.ReadLine();
            Console.Write("Introdusca la edad del la persona q quiere adoptar: ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("Introdusca la direccion del la persona q quiere adoptar: ");
            direccion = Console.ReadLine();
            adoptada = a;
            
            //Console.WriteLine("──────▄▀▄─────▄▀▄\n─────▄█░░▀▀▀▀▀░░█▄\n─▄▄──█░░░░░░░░░░░█──▄▄\n█▄▄█─█░░▀░░┬░░▀░░█─█▄▄█");


        }
        public void mostrar()
        {
            Console.WriteLine("---------------->Adoptante<-----------");
            Console.WriteLine("Nombre: {0}\nEdad: {1}\nDireccion: {2}", nombre, edad, direccion);
            adoptada.mostrar();
        }
    }
}

