using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro.Models;
public class Customer:User
{
    //attributes
    public string MembershipLevel;
    public string PreferedPaymentMethod;
    // Cosntructor
    public Customer(string name,string lastName,string typeDocument,string identificationNumber,string email,string preferedPaymentMethod,string phoneNumber,string Adreess,DateOnly bday ):
    base(name,lastName,typeDocument,identificationNumber,email,phoneNumber,Adreess,bday){

        PreferedPaymentMethod=preferedPaymentMethod;
        UpdateMembershipLevel();

    }
    //methods

    public void UpdateMembershipLevel(){//Establish  the (MembershipLevel) attribute whit a pull of pre-Established options
       //options menu
        Console.WriteLine($@"
        {Name + " " + LastName}, sera pormovido a la posicion:
        Posicion actual:{MembershipLevel}

        1: Platino
        2: Oro
        3: Plata
        4: Bronce

        ");
        //selection space
        ConsoleKeyInfo response = Console.ReadKey();
        switch (response.Key)
        {
            case ConsoleKey.D1://Option 1
                MembershipLevel = "Platino";
                break;
            case ConsoleKey.D2:// Option 2
                MembershipLevel = "Oro";
                break;
            case ConsoleKey.D3://Option 3
                MembershipLevel = "Plata";
                break;
            case ConsoleKey.D4://Option 4
                MembershipLevel = "Bronce";
                break;
            default:
                Console.WriteLine("opcion no valida");
                UpdateMembershipLevel();

                break;
        }
        Console.Clear();
    }
    
    public void ShowCustomerDetails(){//formating all the attributes of the class
        ShowDetails();//inherit method of printing
        Console.WriteLine($"{MembershipLevel,10}{PreferedPaymentMethod,10}");//adition of the native attributes
    }

}
