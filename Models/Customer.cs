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
    // i will pass and create a exception [SafeDateOnyConvertor] to avoid non existing dates
    public Customer(string name,string lastName,string typeDocument,string identificationNumber,string email,string preferedPaymentMethod,string phoneNumber,string Adreess,DateOnly bday ):
    base(name,lastName,typeDocument,identificationNumber,email,phoneNumber,Adreess,bday){

        UpdateMembershipLevel();
        PreferedPaymentMethod=preferedPaymentMethod;

    }
    public void UpdateMembershipLevel(){
        Console.WriteLine($@"
        {Name + " " + LastName}, sera pormovido a la posicion:
        1: Platino
        2: Oro
        3: Plata
        4: Bronce

        0: cancel
        ");
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
            case ConsoleKey.D0:// Retunr to main menu

                Util.RedText("Operaion cancleada");
                Menues.ReturnToMainMenu();
                break;
            default:
                Console.WriteLine("opcion no valida");
                UpdateMembershipLevel();

                break;
        }
    }


}
