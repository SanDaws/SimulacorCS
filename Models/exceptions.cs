using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro.Models;

public static class exceptions
{
    /*
    This class is dedicated to all humanity:
    whitout them i will never have to doit.
    */
    public static int safeInt(string arg)
    {
        int option = 0;
        Console.Write(arg);
        try
        {
            option = Convert.ToInt32(AntiEMptyorNull());
        }
        catch (FormatException)
        {
            Console.WriteLine("Respuesta No valida");
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
            Uti.RedText("Respuesta No valida");
            safeDouble("imposibe convertir, intente con un numero");

        }
        return option;

    }

    public static string AntiEMptyorNull(){
            string text;
        do
        {
            text=Console.ReadLine().Trim();
            if (string.IsNullOrWhiteSpace(text))
            {
                Uti.RedText("Se prohibe texto vacio, ingrese datos validos: ");
            }
        } while (string.IsNullOrWhiteSpace(text));

        return text;
    }
}
