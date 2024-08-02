using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro.Models;
    public static class Util
    {
        //prints the incoming text green
        public static void GreenText(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(texto);
            Console.ResetColor();

        }
        
        //prints the incoming text Red
        public static void RedText(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(texto);
            Console.ResetColor();

        }

        //clears console and wirte a centrated Tittle
        public static void Title(string title,ConsoleColor color){//uses as paramethers the required text and a color from consoleColor
            Console.Clear();
            Console.ForegroundColor = color;
            string upperline = new string('═', Console.WindowWidth - 2);
            Console.WriteLine("╔" + upperline + "╗");
            string midelLine = new string(' ', (Console.WindowWidth / 2) - title.Length/2);
            Console.WriteLine(midelLine + title);
            Console.WriteLine("╚" + upperline + "╝");
            Console.ResetColor();
        }


    //class ends    
    }