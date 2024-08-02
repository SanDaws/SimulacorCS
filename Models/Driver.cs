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

    public Driver(string name,string lastName,string typeDocument,string identificationNumber,string email,string phoneNumber,string Adreess,DateOnly bday,string licenesNumber,string licenseCategory, int drivingExperience ):
    base(name,lastName,typeDocument,identificationNumber,email,phoneNumber,Adreess,bday){
    LicenesNumber=licenesNumber;
    LicenseCategory=licenseCategory;
    DrivingExperience=drivingExperience;
    }
public static string LicenseCategoryKind(){
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
}


