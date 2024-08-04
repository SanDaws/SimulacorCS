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
        //Name
        Console.Write("Nombre del Conductor: ");
        string name= Exceptions.AntiEMptyorNull();
        //LastName
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
        //plate
        Console.Write("Placa del vehiculo: ");
        string plate=Exceptions.AntiEMptyorNull();
        //engineNumber
         Console.Write("Serial/Numero del motor: ");
        string engineNumber=Exceptions.AntiEMptyorNull();
        //Serial number
        Console.Write("Numero serial: ");
        string serialNumber= Exceptions.AntiEMptyorNull();
        //capacity
        byte capacity= Exceptions.SafeByte("Capacidad maxima del vehiculo");

        Database.Database.vehicles.Add(new Vehicle(plate,engineNumber,serialNumber,capacity));
        
    }
    public static void Createcustomer(){
        Util.Title("Nuevo Conductor",ConsoleColor.DarkGreen);
        //Name
        Console.Write("Nombre del Conductor: ");
        string name= Exceptions.AntiEMptyorNull();
        //Last name
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
        
        //creation and adition to the list
        Database.Database.Customers.Add(new Customer(name,lastName,typeDocument,identificationNumber,email,preferedPaymentMethod,phone,Adreess,bday));
        //process succed
        Util.GreenText("Conductor registrado Exitosamente");
        Menues.ReturnToMainMenu();
    }
    
//i can't create a generic list reader, furthemore i create this 3, but all do the same
// the paramether is for not only use when i need to iterate among the main list, also every list i found in the way(including list that linQ returns)

public static void showDrivers(List<Driver> drivers){
    Util.Title("Lista de conductores",ConsoleColor.DarkBlue);
    foreach (var driver in drivers)
    {
        driver.ShowDriverDetails();
    }
    Menues.ReturnToMainMenu();
}
public static void showCustomers(List<Customer>customers){
    Util.Title("Lista de Pasajeros",ConsoleColor.DarkBlue);
    foreach (var customer in customers)
    {
        customer.ShowCustomerDetails();
    }
    Menues.ReturnToMainMenu();
}
public static void showVehicles(List<Vehicle>vehicles){
    Util.Title("Lista de Vehiculos",ConsoleColor.DarkBlue);
    foreach (var vehicle in vehicles)
    {
        vehicle.showVehicleDetails();
    }
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
