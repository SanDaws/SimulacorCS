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
    public string DrivingExperience;

    //methods
    //cosntructor

    public Driver(string name,string lastName,string typeDocument,string identificationNumber,string email,string phoneNumber,string Adreess,DateOnly bday,string licenesNumber,string licenseCategory, string drivingExperience ):
    base(name,lastName,typeDocument,identificationNumber,email,phoneNumber,Adreess,bday){
    LicenesNumber=licenesNumber;
    LicenseCategory=licenseCategory;
    DrivingExperience=drivingExperience;
    }
}
