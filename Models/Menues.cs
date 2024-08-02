using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro.Models;

    public static class Menues
    {
               //Main menue for the User interface
        public static void MainMEnu(){
            Util.Title("TransRiwi",ConsoleColor.Magenta);
            Console.Write($@"
        oprima el numero de opcion  a la que decea acceder
        1: Conductores
        2: Pasajeros
        0: Salir
        ");
            ConsoleKeyInfo response = Console.ReadKey();
            switch (response.Key)
            {
                case ConsoleKey.D1://
                    DriverMenu();
                    break;
                case ConsoleKey.D2:// hacia menu Profesores
                    CustomerMenu();
                    break;
                case ConsoleKey.D0:// Salida

                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("opcion no valida");
                    MainMEnu();

                    break;
            }
        }
        //second menue if its necessary
        public static void DriverMenu(){
            Util.Title("Conductores",ConsoleColor.Blue);
            Console.Write($@"
        oprima el numero de opcion  a la que decea acceder
        1: Lista de estudiantes
        2: Nuevo registro Estudiante
        3: eliminar registro Estudiante
        4: Promedio Del Estudiante
        0: Salir
        ");
            ConsoleKeyInfo response = Console.ReadKey();
            switch (response.Key)
            {
                case ConsoleKey.D1://case purchase menu
                    
                    break;
                case ConsoleKey.D2:// case employe menu
                    
                    break;
                case ConsoleKey.D3:// case customer menu
                    
                    break;
                    case ConsoleKey.D4:// proimedio estudiante
                   
                    break;
                case ConsoleKey.D0:// case exit

                    MainMEnu();
                    break;

                default:
                    Console.WriteLine("opcion no valida");
                    DriverMenu();
                    break;
            }
        }

        public static void CustomerMenu(){
            Util.Title("Pasajeros",ConsoleColor.Blue);
            Console.Write($@"
        oprima el numero de opcion  a la que decea acceder
        1: Lista De Profesores
        2: Nuevo Registro Profesor
        3: eliminar Registro de Profesor
        4: Salario Profesor
        5: editar nombre profesor
        0: Salir
        ");
            ConsoleKeyInfo response = Console.ReadKey();
            switch (response.Key)
            {
                case ConsoleKey.D1://case purchase menu
                    
                    break;
                case ConsoleKey.D2:// case employe menu
                    
                    break;
                case ConsoleKey.D3:// case customer menu
                    
                    break;
                case ConsoleKey.D4:// proimedio estudiante
                   
                    break;
                case ConsoleKey.D5:
                    
                break;
                case ConsoleKey.D0:// case exit

                    MainMEnu();
                    break;

                default:
                    Console.WriteLine("opcion no valida");
                    CustomerMenu();

                    break;
            }
        }
        //generic function to create  returns to the main menu, used for user experience
        public static void ReturnToMainMenu(){
            Console.WriteLine(" oprima cualquier boton para volver al menu...");
            Console.ReadKey();
            MainMEnu();
        }
    }
