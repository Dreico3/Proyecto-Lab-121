using System;
using System.Collections.Generic;
using System.Text;

namespace Proyect8
{
    class Mascota
    {
        private string nombre;
        private string especie;        //perro, gato, canario,etc.
        private string raza;       //raza del animal pastor aleman , loro si es ave etcetc
        private string sexo;        //herbra o macho.
        private int edad, meses,nroregistro;
        private string salud;       //estado de salud en en que se encuentra la mascota
        private string lugar;       //lugar donde fue recojido
        private string vacunas;     //vacunas o tratamientos q nesesita


        public Mascota()
        {
            nombre = "";
            especie = "";
            raza = "";
            sexo = "";
            salud = "";
            lugar = "";
            vacunas = "";
            edad = 0;
            meses = 0;
            nroregistro = 0;
        }
        public Mascota(int q)
        {
            nroregistro = q;
            nombre = "ramon";
            especie = "ave";
            raza = "loro caveza megra";
            sexo = "hembra";
            salud = "bien";
            lugar = "calle";
            vacunas = "Todo en orden";
            edad = 1;
            meses = 3;
        }
        public void registroMas()
        {
            bool flag = true;
            string aux;
            Console.Write("Introdusca el nombre de la mascota: ");
            this.nombre = Console.ReadLine();
            Console.Write("Introdusca la especie de la mascota: ");
            this.especie = Console.ReadLine();
            Console.Write("Introdusca de que raza el {0}: ",this.especie);
            this.raza = Console.ReadLine();
            Console.Write("Introdusca el edad de la mascota (años): ");
            this.edad = int.Parse(Console.ReadLine());
            Console.Write("Introdusca el edad de la mascota (meses): ");
            this.meses = int.Parse(Console.ReadLine());
            Console.Write("Macho o Hembra: ");
            this.sexo = Console.ReadLine();
            Console.WriteLine("Introdusca el lugar donde fue encontrada la mascota: ");
            this.lugar = Console.ReadLine();
            do
            {
                Console.Write("Introdusca el estado de salud de la mascota (Bien o Mal): ");
                aux = Console.ReadLine();
                if (aux.Equals("Bien"))
                {
                    this.salud = "BIEN";
                    this.vacunas = "Todo esta en orden la mascota esta Feliz!!";
                    flag = false;
                }else if (aux.Equals("Mal"))
                {
                    Console.WriteLine("espesificar el tratamiento a seguir o las vacunas q le faltan");
                    this.vacunas = Console.ReadLine();
                    this.salud = "ENFERMO O CON FALTA DE VACUNAS";
                    flag = false;
                }
                else
                {
                    Console.WriteLine("solo tiene q escribir (Bien o Mal)\nNOTA:buelva a escrivir el estado de la mascota");
                    flag = true;
                }

            } while (flag);
        }
        public void mostrar()
        {
            Console.WriteLine("----------->>>{0}<<<----------", especie);
            Console.WriteLine("Nombre: {0}\nRaza:{1} años con {7} Meses\nRaza: {2}\nGenero: {3}\nLugar donde fue recogido-rescatado: {4}\nSalud: {5}\nVacunas o tratamientos:\n {6}", this.nombre, this.edad, this.raza, this.sexo, this.lugar, this.salud, this.vacunas,this.meses);
            Console.WriteLine("──────▄▀▄─────▄▀▄\n─────▄█░░▀▀▀▀▀░░█▄\n─▄▄──█░░░░░░░░░░░█──▄▄ Codigo: {0}\n█▄▄█─█░░▀░░┬░░▀░░█─█▄▄█",nroregistro);
        }

    }
}
