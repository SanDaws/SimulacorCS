using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro.Models;

    public static class Menues
    {
        /*important thig:
        this menues works by recursivness
        that means i got no loops in for the running of the menues, it will always iterate the same function by itself
        */

        //Main menue for the User interface
        public static void MainMenu(){
        Util.Title("TransRiwi",ConsoleColor.Magenta);//fancy Tittles
        Console.Write($@"
        oprima el numero de opcion  a la que decea acceder
        1: Conductores
        2: Pasajeros
        3: Vehiculos

        0: Salir
        ");
        //all the menues works the same
            ConsoleKeyInfo response = Console.ReadKey();
            switch (response.Key)
            {
                case ConsoleKey.D1:// Drivers Menu
                    DriverMenu();
                    break;
                case ConsoleKey.D2:// Customer Menu
                    CustomerMenu();
                    break;
                case ConsoleKey.D3: // vehicle Menu
                VehicleMenue();
                break;
                case ConsoleKey.D0:// exit

                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("opcion no valida");
                    MainMenu();

                    break;
            }
        }
        //Drivers Menue
        public static void DriverMenu(){
            Util.Title("Conductores",ConsoleColor.Blue);
            Console.Write($@"
        oprima el numero de opcion  a la que decea acceder
        1: Lista Conductores
        2: Nuevo registro de Conductor
        3: eliminar registro de Conductor
        4: 

        0: Salir
        ");
            ConsoleKeyInfo response = Console.ReadKey();
            switch (response.Key)
            {
                case ConsoleKey.D1://case read
                    UserOperations.showDrivers(Database.Database.drivers);
                    break;
                case ConsoleKey.D2:// case create
                    UserOperations.CreateDriver();
                    break;
                case ConsoleKey.D3:// case Delete
                    
                    break;
                    case ConsoleKey.D4:// 
                   
                    break;
                case ConsoleKey.D0:// case Return Menu

                    MainMenu();
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
        1: Listar usuarios Pasajeros
        2: Nuevo Registro de pasajero
        3: eliminar Registro de pasajero
        4: 
        5: 

        0: Salir
        ");
            ConsoleKeyInfo response = Console.ReadKey();
            switch (response.Key)
            {
                case ConsoleKey.D1://case read
                    UserOperations.showCustomers(Database.Database.Customers);
                    break;
                case ConsoleKey.D2:// case create
                    UserOperations.Createcustomer();
                    break;
                case ConsoleKey.D3:// case delete
                    
                    break;
                case ConsoleKey.D4:// 
                   
                    break;
                case ConsoleKey.D5:
                    
                break;
                case ConsoleKey.D0:// case exit

                    MainMenu();
                    break;

                default:
                    Console.WriteLine("opcion no valida");
                    CustomerMenu();

                    break;
            }
        }
        // vehicles Menu
        public static void VehicleMenue(){
            Util.Title("Vehiculos",ConsoleColor.DarkGray);
            Console.Write($@"
        oprima el numero de opcion  a la que decea acceder
        1: Lista de vehiculos
        2: Nuevo registro de Vehiculo
        3: eliminar Registro de vehiculo
        4: 
        5: 
        
        0: Salir
        ");
            ConsoleKeyInfo response = Console.ReadKey();
            switch (response.Key)
            {
                case ConsoleKey.D1://case list of vehicule
                    UserOperations.showVehicles(Database.Database.vehicles);
                    break;
                case ConsoleKey.D2:// case create vehicle
                    UserOperations.CreateVehicle();
                    break;
                case ConsoleKey.D3:// case delete vehicle
                    
                    break;
                case ConsoleKey.D4:// 
                   
                    break;
                case ConsoleKey.D5:
                    
                break;
                case ConsoleKey.D0:// case exit

                    MainMenu();
                    break;

                default:
                    Console.WriteLine("opcion no valida");
                    VehicleMenue();

                    break;
            }
        }
        //generic function to create  returns to the main menu, used for user experience
        public static void ReturnToMainMenu(){
            Console.WriteLine(" oprima cualquier boton para volver al menu...");
            Console.ReadKey();
            Console.Clear();
            MainMenu();
        }
    }
