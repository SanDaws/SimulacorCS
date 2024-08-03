using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro.Database;

namespace Simulacro.Models
{
    public class Vehicle
    {
        public int Id;
        public string LicensePlate;
        public string VehicleType;
        public string EngineNumber;
        public string SerialNumber;
        public byte PeopleCapacity;//this should be using a sbyte, for the memory optimization
        public Driver Owner;
        // this is a asociation not a aggregartion beacuse it's required a Driver for the existance of a vehicle in the transport system
        //cosntructor
        public Vehicle(string licensePlate, string engineNumber,string serialNumber,byte peopleCapacity,Driver Owner){
            Id= Database.Database.VehicleIdGenerator();
            LicensePlate=licensePlate;
            VehicleType=VehicleTypes();
            EngineNumber=engineNumber;
            SerialNumber=serialNumber;
            PeopleCapacity=peopleCapacity;
            this.Owner=Owner;
        }
        //this may be in a loop, so maybe i will put it to iterate itself
        public static void DeleteVehicle(int id){
            Vehicle? res = Database.Database.vehicles.FirstOrDefault(p => p.Id == id);
            if (res!= null)
            {
                Database.Database.vehicles.Remove(res);
            }
            else
            {
                Util.RedText("Registro No encotrado");
            }
            Util.GreenText("Registro de Vehiculo borrado Exitosamente");

        }
        //shows its own attributes
        public void showVehicleDetails()
        {
            Console.WriteLine($"{Id,10}{LicensePlate,15}{VehicleType,12}{EngineNumber,10}{SerialNumber,20}{PeopleCapacity,10}{Owner.DriverName(),30}");
        }

        public string VehicleTypes()
        {
            Console.WriteLine($@"
    Categoria de Licensia:
    1: Moto
    2: Carro
    3: Camioneta
    4: Microbus
    ");
            ConsoleKeyInfo response = Console.ReadKey();
            switch (response.Key)
            {
                case ConsoleKey.D1:
                Console.Clear();
                    return "Moto";
                case ConsoleKey.D2:
                Console.Clear();
                    return "Carro";
                case ConsoleKey.D3:
                Console.Clear();
                    return "Camioneta";
                case ConsoleKey.D4:
                Console.Clear();
                    return "Microbus";
                default:
                    Util.RedText("opcion no valida o existente");
                    VehicleTypes();
                    break;
            }
            Console.Clear();
            return "Moto";

        }
    }
}