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
    public static int safeInt(string arg)
    {
        int option = 0;
        Console.Write(arg+": ");
        try
        {
            option = Convert.ToInt32(AntiEMptyorNull());
        }
        catch (FormatException)
        {
            Util.RedText("Respuesta No valida");
            safeInt("imposibe convertir, intente con un numero");

        }
        return option;

    }
    public static double safeDouble(string arg)
    {
        double option= 0;
        Console.Write(arg+": ");
        try
        {
            option = Convert.ToDouble(AntiEMptyorNull());
        }
        catch (FormatException)
        {
            Util.RedText("Respuesta No valida");
            safeDouble("imposibe convertir, intente con un numero");

        }
        return option;

    }

    public static string AntiEMptyorNull(){
            string? text;
        do
        {
            text=Console.ReadLine().Trim();
            if (string.IsNullOrWhiteSpace(text))
            {
                Util.RedText("Se prohibe texto vacio, ingrese datos validos: ");
            }
        } while (string.IsNullOrWhiteSpace(text));

        return text;
    }
    public static DateOnly SafeDateonly()
    {

        //Data obtainig
        DateOnly now = DateOnly.FromDateTime(DateTime.Now);
        DateOnly thatDay = new DateOnly();

        int day = safeInt("Dia de Naciemiento");



        int month = safeInt("Mes de Naciemiento");
        int year = safeInt("Año de nacimiento");

        try
        {
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
        return thatDay;

    }
}
