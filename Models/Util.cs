using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro.Models;
    public static class Util
    {
        //prints the incoming text green
        public static void GreenText(string texto)
        {//fancy text for easy comprehension of the user
            Console.ForegroundColor = ConsoleColor.Green;//change color
            Console.Write(texto);//writes text whit the new color
            Console.ResetColor();//resets the text

        }
        
        //prints the incoming text Red
        public static void RedText(string texto)
        {//sames as the function aboves
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(texto);
            Console.ResetColor();

        }

        //clears console and wirte a centrated Tittle
        public static void Title(string title,ConsoleColor color){//uses as paramethers the required text and a color from consoleColor
            Console.Clear();
            Console.ForegroundColor = color;
            string upperline = new string('═', Console.WindowWidth - 2);//calculate the size of the console window  
            Console.WriteLine("╔" + upperline + "╗");//the -2 of the line before is just for put this border lines
            string midelLine = new string(' ', (Console.WindowWidth / 2) - title.Length/2);// centers the text that we will use
            Console.WriteLine(midelLine + title);//displays title
            Console.WriteLine("╚" + upperline + "╝");//reuse the first line
            Console.ResetColor();// reset all the colors for the printing the rest of the code
        }


    //class ends    
    }