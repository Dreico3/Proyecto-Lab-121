using System;

namespace Proyect8
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            bool flag = true;
            Albergue a = new Albergue();
            Albergue a2 = new Albergue("los hermnaos pollo", "av. buch nr 72");
            Albergue a3 = new Albergue("Aristogatos", "calle ramos esq. jordan");

            do
            {
                Console.WriteLine("lista de albergues (escoja un numero)\n|->1) {0}\n|->2) {1}\n|->3) {2}\n|-->4)Salir?", a.Nombre, a2.Nombre, a3.Nombre);
                aux = Console.ReadLine();
                if (aux.Equals("1"))
                {
                    
                     a.menu();
                }
                else if (aux.Equals("2"))
                {
                    a2.menu();
                }
                else if (aux.Equals("3"))
                {
                    a3.menu();
                }
                else if (aux.Equals("4"))
                {   
                    flag = false;
                }
                else
                {
                    Console.WriteLine("las opciones introducidas no son validas");
                    flag = true;
                }
            } while (flag);
            

            Console.ReadKey();
        }
    }
}
