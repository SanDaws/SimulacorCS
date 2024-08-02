using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro.Models;

public class User{
    //atributes
    protected Guid id;
    protected string Name;
    protected string LastName;
    protected string TypeDocument;
    protected string IdentificationNumber;
    protected DateOnly BrithDate;
    protected string Email;
    protected string PhoneNumber;
    protected string Adreess;

//methods
//constructor
    protected User(string Name,string LastName,string TypeDocument,string IdentificationNumber,string Email,string PhoneNumber,string Adreess,DateOnly b_Day){
        id= Guid.NewGuid();
        this.Name=Name;
        this.LastName=LastName;
        this.TypeDocument=TypeDocument;
        this.IdentificationNumber=IdentificationNumber;
        this.Email=Email;
        this.PhoneNumber=PhoneNumber;
        this.Adreess=Adreess;
        BrithDate=b_Day;

    }
    //shows all the data of this class
    protected void ShowDetails(){
        
        Console.Write($"{id,20}{Name +" "+ LastName,30}{TypeDocument,10}:{IdentificationNumber,15}{CalculateAge(),5}{Email,50}{PhoneNumber,20}{Adreess,30}");
    }
//only returns a simple date comparison
    protected int CalculateAge(){
        DateOnly datenow=DateOnly.FromDateTime(DateTime.Now);
        
        return datenow.Year - BrithDate.Year;
    }
// for real i got no idea why this function is here
    protected void ShowAge(){
        Console.Write(CalculateAge());
    }

}
