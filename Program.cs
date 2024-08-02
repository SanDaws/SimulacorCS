using Simulacro.Models;

namespace Simulacro;

class Program
{
    static void Main()
    {
        Exceptions.SafeDateonly();
        Database.Database.BurnedData();
        Menues.MainMenu();
    }
}
