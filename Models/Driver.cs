using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro.Models;
public class Driver:User
{
    //atributes
    public string LicenesNumber;
    public string LicenseCategory;
    public int DrivingExperience;

    //methods
    //cosntructor
    public Driver(string name,string lastName,string typeDocument,string identificationNumber,string email,string phoneNumber,string Adreess,DateOnly bday,string licenesNumber, int drivingExperience ):
    base(name,lastName,typeDocument,identificationNumber,email,phoneNumber,Adreess,bday){
    LicenesNumber=licenesNumber;
    LicenseCategory=LicenseCategoryKind();
    DrivingExperience=drivingExperience;
    }
//Selection Menu for the type of license the driver have
public  string LicenseCategoryKind(){
    Console.WriteLine($@"
    Categoria de Licensia:
    1: A2
    2: B2");
   ConsoleKeyInfo response= Console.ReadKey();
    switch (response.Key)
    {
        case ConsoleKey.D1:
        Console.Clear();
        return "A2";
        case ConsoleKey.D2:
        Console.Clear();
        return "B2";
        default:
        Util.RedText("opcion no valida o existente");
        LicenseCategoryKind();
        break;
    }
    return "A2";// default case, doesn't happen but in hte remote case someone jumps this loop it will return A2 license
}

public void ShowDriverDetails(){
    
        ShowDetails();//because of his level of protection, you cant override this funcion, in my way to not find out losing time, i just callit and add what  i need
        Console.WriteLine($"{LicenseCategory,10}{LicenesNumber,15}{DrivingExperience,4}");// adition at the end of the console line
    }

//This is usefull for some searches
public string DriverName(){
    return $"{Name+" "+LastName}";
}
//this is used in the register of the drivers, and adding as object to de Vehicle objects
public static void DriversList(List<Driver> drivers){//merely visual function, but usefull for user interface
    foreach (var driver in drivers)
    {
        Console.WriteLine($"|{drivers.IndexOf(driver),20}|{driver.DriverName(),40}|");
    }
}

}


