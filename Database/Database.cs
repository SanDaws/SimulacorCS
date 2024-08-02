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

    }
}
