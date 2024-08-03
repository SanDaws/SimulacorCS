using Simulacro.Models;

namespace Simulacro;

class Program
{
    static void Main()
    {
        /*Important disclaimer
        most of the time in the menues you don't need to press enter, beacuase
        ir reads the key input not a console readline*/
        Database.Database.BurnedData();
        Console.Clear();
        Menues.MainMenu();
    }
}
