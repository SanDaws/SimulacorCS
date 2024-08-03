using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro.Models;

namespace Simulacro.Database;

public class Database
{
    //all the list that simulate a database
    public static List<Customer> Customers= new List<Customer>();
    public static List<Vehicle> vehicles=new List<Vehicle>();
    public static List<Driver> drivers = new List<Driver>();

    //autogeneration of numeric Id(implemented in vehicle Id), returns an integer
    public static int VehicleIdGenerator(){
        //this method will look in the vehicle list, look for the lenght, add +1, lok if that number is alredy, and give aditional number untill finds a non number
        int IdNew = vehicles.Count + 1;// based on the vehicle lenght he will give a number

        do
        {//search for the existance of newid, if alredy exist, increase the number untill there is no id in the list
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
    //burnedData creation
    public static void BurnedData(){
        //adition of customers
        Customers.Add(new Customer("Andres","pumarejo","CC","10005612164","pumarejo@gmail.com","Tarjeta de Credito","+57 322448523","cra 75# 52-52", new DateOnly(1999,12,1)));
        Customers.Add(new Customer("Camila","pumarejo","CC","10005412164","pumarejo2@gmail.com","Efectivo","+57 322448525","cra 75# 52-50", new DateOnly(1999,10,1)));
        //adition of drivers
        drivers.Add(new Driver("camilo","Guzman","CC","126511348","guca@gmail.com","+57 3282364496","calle 55# 25-76",new DateOnly(2003,1,1),"A151325643",5));
        drivers[0].LicenseCategory="A2";
        drivers.Add(new Driver("Carolina","Guzman","CC","1265115498","caro213@gmail.com","+57 325614496","calle 55# 25-76",new DateOnly(2003,1,1),"A151325643",2));
        drivers[0].LicenseCategory="B2";
        //adition of vehicles
        vehicles.Add(new Vehicle("A564DF","45S6123A-A52014S54D","AAAA0000",5,drivers[0]));
        vehicles[0].VehicleType="Microbus";
        vehicles.Add(new Vehicle("A5645F","45SAS23A-A52014S54D","AAAASFK00",2,drivers[1]));
        vehicles[0].VehicleType="Moto";
        Console.Clear();

        
    }
}
