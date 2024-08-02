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
public  string LicenseCategoryKind(){
    Console.WriteLine($@"
    Categoria de Licensia:
    1: A2
    2: B2");
   ConsoleKeyInfo response= Console.ReadKey();
    switch (response.Key)
    {
        case ConsoleKey.D1:
        return "A2";
        case ConsoleKey.D2:
        return "B2";
        default:
        Util.RedText("opcion no valida o existente");
        LicenseCategoryKind();
        break;
    }
    return "A2";
}

public void ShowDriverDetails(){
        base.ShowDetails();
        Console.WriteLine($"{LicenseCategory,10}{LicenesNumber,10}{DrivingExperience}");
    }

//create a list that returns index of the driver
public string DriverName(){
    return $"{Name+" "+LastName}";
}

public void DriversList(List<Driver> drivers){
    foreach (var driver in drivers)
    {
        Console.WriteLine($"{drivers.IndexOf(driver)}{DriverName()}");
    }
}

}


