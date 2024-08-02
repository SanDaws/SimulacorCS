using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro.Models;

namespace Simulacro.Database;

public static class Database
{
    public static List<Customer> Customers= new List<Customer>();
    public static List<Vehicle> vehicles=new List<Vehicle>();
    public static List<Driver> drivers = new List<Driver>();

    public static int VehicleIdGenerator(){
        //this method will look in the vehicle list, look for the lenght, add +1, lok if that number is alredy, and give aditional number untill finds a non number
        int IdNew = vehicles.Count + 1;

        do
        {
            Vehicle? res = vehicles.FirstOrDefault(p => p.Id == IdNew);
            if (res != null)
            {
                IdNew += 1;
            }
            else if (res == null)
            {
                break;
            }
        } while (true);
        return IdNew;
    }
}
