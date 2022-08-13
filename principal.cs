using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Semana_3_proyecto_consola_menu

{
 
    class principal
    {

            static void Main(string[] args)
            {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Title = "Programa de menu  \n\n";

            System.Console.WriteLine("Proyecto de Menu \n");
                System.Console.WriteLine("Grupos de trabajo ");

                System.Console.ReadKey();

                int repetir;

                //menu_interno();

                do
                {
                    menu_interno();

                    System.Console.WriteLine("\nIngrese 1 para repetir menú");

                    System.Console.WriteLine("Ingrese 2 para salir");
                    repetir = Int32.Parse(Console.ReadLine());

                } while (repetir == 1);

            } //Cierre de función principal


            //Inicio de funciones interna
            static void menu_interno()
            {
                string opcion;
                int opcionint;

                System.Console.WriteLine("\nMenu Grupos");
            Console.WriteLine("------------------------");    
            System.Console.WriteLine("1. Primer Grupo ");
                System.Console.WriteLine("2. Segundo Grupo");
                System.Console.WriteLine("3. Tercer Grupo");
                System.Console.WriteLine("4. Cuarto grupo");
                System.Console.WriteLine("5. Quinto grupo");

                System.Console.WriteLine("Selecciona tu opcion: ");
                opcion = Console.ReadLine();
                opcionint = Int32.Parse(opcion);

                switch (opcionint)
                {
                    case 1:
                        //Ejemplo para llamar clase externa
                        programa_if();

                        //llamada función interna
                        //programa_if();
                        break;

                    case 2:
                        //llamada de función interna
                        programa_switch();
                        break;

                    case 3:
                        //llamada de función interna
                        programa_for();
                        break;

                    case 4:
                        //llamada de función interna
                        programa_while();
                        break;
                    case 5:
                        //llamada de función interna
                        programa_dowhile();
                        break;
                }

            }

            //Función interna para ejemplo if
            static void programa_if()
            {
                System.Console.WriteLine("\nLos integrantes son : Daniel, Tania, Roberto");

            }

            //Función interna para ejemplo switch
            static void programa_switch()
            {
                System.Console.WriteLine(" \nLos integrantes son : Monica,Cristian,Ivania \n");
            }

            //Función interna para ejemplo for
            static void programa_for()
            {
                System.Console.WriteLine("\nLos integrantes son : Gustavo,Fredy,Lorena\n");
            }

            //Función interna para ejemplo while
            static void programa_while()
            {
                System.Console.WriteLine("\nLos integrantes son : Salvador, Carlos, Dayana \n");
            }

            //Función interna para ejemplo dowhile
            static void programa_dowhile()
            {
                System.Console.WriteLine("\nLos integrantes son : Jose,Maria, Paola\n");
            }

            //Fin de funciones internas





        }



    }

