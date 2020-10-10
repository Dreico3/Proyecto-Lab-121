using System;
using System.Collections.Generic;
using System.Text;

namespace Proyect8
{
    class Albergue
    {
        private string nombre;
        private string uvicacion;
        private int capMascota;     //capasidad de mascotas
        private int nroMascotas;    //numero de mascotas alojadas
        private Mascota[] ma;
        private Adoptante[] a;
        private int nroAdoptante;
        public Albergue()
        {
            nombre = "los santos";
            uvicacion = "av los andes, Km 8";
            capMascota = 50;
            nroMascotas = 5;
            //creando mascotas
            ma = new Mascota[capMascota];
           
            for (int i = 0; i < nroMascotas; i++)
            {
                ma[i] = new Mascota(i + 1);
            }
            //creando adoptantes
            a = new Adoptante[50];
            nroAdoptante = 1;
            a[0] = new Adoptante(ma[2]);

        }
        public Albergue(string nom,string uvi)
        {
            nombre = nom;
            uvicacion = uvi;
            capMascota = 50;
            nroMascotas = 5;
            //creando mascotas
            ma = new Mascota[capMascota];

            for (int i = 0; i < nroMascotas; i++)
            {
                ma[i] = new Mascota(i + 1);
            }
            //creando adoptantes
            a = new Adoptante[50];
            nroAdoptante = 1;
            a[0] = new Adoptante(ma[2]);

        }
        public void menu()
        {
            string aux;
            bool flag = true;
            do
            {
                //Console.WriteLine("lista de albergues (escoja un numero)\n|->1) {0}\n|->2) {1}\n|->3) {2}\n|-->4)Salir?", a.Nombre, a2.Nombre, a3.Nombre);
                //aux = Console.ReadLine();
                //if (aux.Equals("1"))
                //{
                    Console.WriteLine("-->>>{0}\n1)Mostrar mascotas disponibles\n2)agregar mascota\n3)agregar adoptador\n4)Mostrar Adoptadores\npreciones cualquier tecla paa salir", nombre);
                    aux = Console.ReadLine();
                    if (aux.Equals("1"))
                    {
                        mostrarmascotas();
                    }
                    else if (aux.Equals("2"))
                    {
                        agregarMasco();
                    }
                    else if (aux.Equals("3"))
                    {
                        agregarAdop();
                    }
                    else if (aux.Equals("4"))
                    {
                        mostrarAdop();
                    }
                    else
                    {
                        flag = false;
                    }
                //}
            } while (flag);
        }
        public void mostrar()
        {
            Console.WriteLine("Nombre alberge: {0}\nDireccion: {1}\nCapasidad de mascotas: {2}\nnumero de mascotas disponibles: {3}", nombre, uvicacion, capMascota, nroMascotas);
        }
        public void agregarAdop()
        {
            this.nroAdoptante++;
            int aux = 0;
            Console.WriteLine("agrege el codigo de la mascota");
            aux = int.Parse(Console.ReadLine());
            a[nroAdoptante - 1] = new Adoptante();
            a[nroAdoptante - 1].registroAdoptante(ma[aux-1]);
        }
        public void agregarMasco()
        {
            this.nroMascotas++;
            ma[nroMascotas - 1] = new Mascota(nroMascotas);
            ma[nroMascotas - 1].registroMas();
        }
        public void mostrarmascotas()
        {
            for (int i = 0; i < nroMascotas; i++)
            {
                ma[i].mostrar();
            }
        }
        public void mostrarAdop()
        {
            for (int i = 0; i < nroAdoptante; i++)
            {
                a[i].mostrar();
            }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Uvicacion
        {
            get { return uvicacion; }
            set { this.uvicacion = value; }
        }
    }
}
