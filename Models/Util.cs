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
        //recorrido de listas en busquedas
        //profesores
        public static void ListarProfesores(List<Profesor> profesores, string texto){
            Title(texto,ConsoleColor.DarkGreen);

            foreach (var profesor in profesores)
            {
                profesor.MostrarDetalles();
            }
            Console.WriteLine(" oprima cualquier boton para volver al menu...");
            Console.ReadKey();
            Menuprofesores();
        }
        public static void ListarEstudiantes(List<Estudiante> estudiantes,string texto){
            Title(texto,ConsoleColor.DarkGreen);

            foreach (var estudiante in estudiantes)
            {
                estudiante.MostrarDetalles();
            }
            Console.WriteLine(" oprima cualquier boton para volver al menu...");
            Console.ReadKey();
            StudentMEnu();
        }
        
        //estas al ser funciones de menu de usuario, las pondre aqui en lugar de ponerlas dentro de la clase administradorapp
        public static  void NuevoEstudiante(){
            Title("Nuevo Estudiante",ConsoleColor.DarkGreen);
            //nombre
            Console.Write("Nombre del estudiante: ");
            string Nombre= exceptions.AntiEMptyorNull();
            //apellido
            Console.Write("Apellido: ");
            string Apellido= exceptions.AntiEMptyorNull();
            //tipo de docuemto
            Console.Write("Tipo de Documento: ");
            string TipoDocumento= exceptions.AntiEMptyorNull();
            //numero de docuemto
            Console.Write("Numero de Documento: ");
            string NumeroDocumento= exceptions.AntiEMptyorNull();
        // email
            Console.Write("Email: ");
            string Email= exceptions.AntiEMptyorNull();
            //acudiente
            Console.Write("Nombre del Acudeinte: ");
            string NombreAcudiente= exceptions.AntiEMptyorNull();
            //telefono
            Console.Write("Numero de telefono: ");
            string Telefono= exceptions.AntiEMptyorNull();
            //telefono
            Console.Write("Curso Actual: ");
            string CursoActual= exceptions.AntiEMptyorNull().ToUpper();
            //fecha
            int dia= exceptions.safeInt("Dia de Nacimiento: ");
            int month= exceptions.safeInt("Mes de Nacimiento: " );
            int year= exceptions.safeInt("Año de Nacimiento: ");
            
            AdministradorApp.Estudiantes.Add(new Estudiante(Nombre,Apellido,TipoDocumento,NumeroDocumento,Email,Telefono,NombreAcudiente,CursoActual,dia,month,year));
            GreenText("Nuevo Estudiante registrado satisfactoriamente");

            Console.WriteLine(" oprima cualquier boton para volver al menu...");
            Console.ReadKey();
            StudentMEnu();
        } 
        //creacion nuevo profesor
        public static  void NuevoProfesor(){
            Title("Nuevo Profesor",ConsoleColor.DarkGreen);
            //nombre
            Console.Write("Nombre del Profesor: ");
            string Nombre= exceptions.AntiEMptyorNull();
            //apellido
            Console.Write("Apellido: ");
            string Apellido= exceptions.AntiEMptyorNull();
            //tipo de docuemto
            Console.Write("Tipo de Documento: ");
            string TipoDocumento= exceptions.AntiEMptyorNull();
            //numero de docuemto
            Console.Write("Numero de Documento: ");
            string NumeroDocumento= exceptions.AntiEMptyorNull();
        // email
            Console.Write("Email: ");
            string Email= exceptions.AntiEMptyorNull();
            //acudiente
            Console.Write("Nombre del Acudeinte: ");
            string Asignatura= exceptions.AntiEMptyorNull();
            //telefono
            Console.Write("Numero de telefono: ");
            string Telefono= exceptions.AntiEMptyorNull();
            //Salario
            double Salario= exceptions.safeDouble("Salario");
            //fecha de contratacion
            int dia= exceptions.safeInt("Dia decontratacion: ");
            int month= exceptions.safeInt("Mes de contratacion " );
            int year= exceptions.safeInt("Año decontratacion: ");

            AdministradorApp.Profesores.Add(new Profesor(Nombre,Apellido,TipoDocumento,NumeroDocumento,Email,Telefono,Asignatura,Salario,dia,month,year));
            
            GreenText("Nuevo Profesor registrado satisfactoriamente");

            Console.WriteLine(" oprima cualquier boton para volver al menu...");
            Console.ReadKey();
            StudentMEnu();
        } 

     public static void EditarNombrePRofesor(){
        Uti.Title("Editar Profesor",ConsoleColor.Cyan);
        Console.Write("Documento Del profesor ");
            string Documento= exceptions.AntiEMptyorNull();
            Console.Write("Nombre del Profesor: ");
            string NuevoNombre= exceptions.AntiEMptyorNull();
            Profesor.editarNombre(Documento,NuevoNombre);
     }
        


    //class ends    
    }