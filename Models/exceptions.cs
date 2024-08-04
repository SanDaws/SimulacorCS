using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro.Models;

public static class Exceptions
{
    /*
    This class is dedicated to all humanity:
    whitout them i will never have to doit.
    */
    public static int safeInt(string arg) // this will creates a loop for the users, but at the ends returns an integer
    {
        int option = 0;
        Console.Write(arg+": ");
        try
        {
            option = Convert.ToInt32(AntiEMptyorNull());
        }
        catch (FormatException)// Exception for impossible to convert
        {
            Util.RedText("Respuesta No valida");
            safeInt($"imposibe convertir,{arg}");//restart the cicle
        }
        return option;

    }
    public static double SafeDouble(string arg){// this will creates a loop for the users, but at the ends returns an double
        double option= 0;
        Console.Write(arg+": ");
        try
        {
            option = Convert.ToDouble(AntiEMptyorNull());
        }
        catch (FormatException)
        {
            Util.RedText("Respuesta No valida");
            SafeDouble($"imposibe convertir, {arg}");

        }
        return option;

    }

    public static string AntiEMptyorNull(){// most for strings, but avoids the null or empty posibility in a string
            string? text;
        do
        {
            text=Console.ReadLine().Trim();// trims both sides of the code
            if (string.IsNullOrWhiteSpace(text))
            {
                Util.RedText("Se prohibe texto vacio, ingrese datos validos: ");
            }
        } while (string.IsNullOrWhiteSpace(text));

        return text;
    }

    //safetly generation of date inputs
    public static DateOnly SafeDateonly(){
        //it can be used  for more thigs, but for the instance of this proyect its only used for birth dates

        //Data obtainig
        DateOnly now = DateOnly.FromDateTime(DateTime.Now);
        DateOnly thatDay = new DateOnly();

        int day = safeInt("Dia de Naciemiento");
        int month = safeInt("Mes de Naciemiento");
        int year = safeInt("Año de nacimiento");

        try
        {//attempt to convert
            thatDay = new DateOnly(year, month, day);
        }
        catch (ArgumentOutOfRangeException)
        {
            Util.RedText("Fecha no existente");
            SafeDateonly();
        }
        //probe that the year is not for the future
        if (thatDay.Year > now.Year)
        {
            Util.RedText("Fecha no existente(fecha futura)");
            SafeDateonly();

        }
        return thatDay;//it wilñl return a complete date 

    }
    public static byte SafeByte(string arg){
        byte option= 0;
        Console.Write(arg+": ");
        try
        {
            option = Convert.ToByte(AntiEMptyorNull());
        }
        catch (FormatException)
        {
            Util.RedText("Respuesta No valida");
            SafeDouble($"imposibe convertir, {arg}");

        }
        catch(ArgumentOutOfRangeException){
            Util.RedText("Respuesta No valida(Numero Demasiado alto)");
            SafeDouble($"imposibe convertir, {arg}");
        }
        return option;
    }
}
