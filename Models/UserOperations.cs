using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro.Models;

public static class UserOperations
{
    // class dedicated to the operations of the user in the user interface
    public static void CreateDriver(){
        Util.Title("Nuevo Conductor",ConsoleColor.DarkGreen);
        //nombre
        Console.Write("Nombre del Conductor: ");
        string name= Exceptions.AntiEMptyorNull();
        //apellido
        Console.Write("Apellido: ");
        string lastName= Exceptions.AntiEMptyorNull();
        //Type of documet
        Console.Write("Tipo de Documento: ");
        string typeDocument= Exceptions.AntiEMptyorNull();
        //Document number
        Console.Write("Numero de Documento: ");
        string identificationNumber= Exceptions.AntiEMptyorNull();
    // email
        Console.Write("Email: ");
        string email= Exceptions.AntiEMptyorNull();
        //phone
        Console.Write("Numero de telefono: ");
        string phone= Exceptions.AntiEMptyorNull();
        //Adreess
        Console.Write("Direccion: ");
        string Adreess= Exceptions.AntiEMptyorNull().ToUpper();
        DateOnly bday= Exceptions.SafeDateonly();

        
        Console.Write("Numero de Licensia: ");
        string licenseNumber= Exceptions.AntiEMptyorNull();

        int experience= Exceptions.safeInt("Años de experiencia");

        Database.Database.drivers.Add(new Driver(name,lastName,typeDocument,identificationNumber,email,phone,Adreess,bday,licenseNumber,experience));
        
        Util.GreenText("Conductor registrado Exitosamente");
        Menues.ReturnToMainMenu();

    }
    
    public static void CreateVehicle(){
        
    }
    public static void Createcustomer(){
        Util.Title("Nuevo Conductor",ConsoleColor.DarkGreen);
        //nombre
        Console.Write("Nombre del Conductor: ");
        string name= Exceptions.AntiEMptyorNull();
        //apellido
        Console.Write("Apellido: ");
        string lastName= Exceptions.AntiEMptyorNull();
        //Type of documet
        Console.Write("Tipo de Documento: ");
        string typeDocument= Exceptions.AntiEMptyorNull();
        //Document number
        Console.Write("Numero de Documento: ");
        string identificationNumber= Exceptions.AntiEMptyorNull();
    // email
        Console.Write("Email: ");
        string email= Exceptions.AntiEMptyorNull();
        //phone
        Console.Write("Numero de telefono: ");
        string phone= Exceptions.AntiEMptyorNull();
        //way to pay
        Console.Write("Metodo Preferido De pago: ");
        string preferedPaymentMethod= Exceptions.AntiEMptyorNull();
        //Adreess
        Console.Write("Direccion: ");
        string Adreess= Exceptions.AntiEMptyorNull().ToUpper();
        DateOnly bday= Exceptions.SafeDateonly();
        



        Database.Database.Customers.Add(new Customer(name,lastName,typeDocument,identificationNumber,email,preferedPaymentMethod,phone,Adreess,bday));
        
        Util.GreenText("Conductor registrado Exitosamente");
        Menues.ReturnToMainMenu();
    }
    



    // public static void EditarNombrePRofesor(){
    // Uti.Title("Editar Profesor",ConsoleColor.Cyan);
    // Console.Write("Documento Del profesor ");
    //     string Documento= Exceptions.AntiEMptyorNull();
    //     Console.Write("Nombre del Profesor: ");
    //     string NuevoNombre= Exceptions.AntiEMptyorNull();
    //     Profesor.editarNombre(Documento,NuevoNombre);
    // }
    

    
}
