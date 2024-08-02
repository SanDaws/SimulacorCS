using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro.Models
{
    public class Vehicle
    {
        public int Id;
        public string LicensePlate;
        public string VehicleType;
        public string EngineNumber;
        public string SerialNumber;
        public byte PeopleCapacity;//this may be a sbyte, for the memory optimization
        public Driver Owner;
        // this is a asociation not a aggregartion beacuse it's required a Driver for the existance of a vehicle in the transport system
        public Vehicle(string licensePlate,string vehicleType, string engineNumber,string serialNumber,byte peopleCapacity,Driver Owner){
            LicensePlate=licensePlate;
            VehicleType=vehicleType;
            EngineNumber=engineNumber;
            SerialNumber=serialNumber;
            PeopleCapacity=peopleCapacity;
            this.Owner=Owner;
        }
        public void DeleteVehicle(int id){

        }
    }
}