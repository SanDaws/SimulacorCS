using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro.Models
{
    public static class UserOperations
    {
        // class dedicated to the creation modification and 
        public static void CreateDriver(){
            Util.Title("Nuevo Estudiante",ConsoleColor.DarkGreen);
            //nombre
            Console.Write("Nombre del estudiante: ");
            string Nombre= Exceptions.AntiEMptyorNull();
            //apellido
            Console.Write("Apellido: ");
            string Apellido= Exceptions.AntiEMptyorNull();
            //tipo de docuemto
            Console.Write("Tipo de Documento: ");
            string TipoDocumento= Exceptions.AntiEMptyorNull();
            //numero de docuemto
            Console.Write("Numero de Documento: ");
            string NumeroDocumento= Exceptions.AntiEMptyorNull();
        // email
            Console.Write("Email: ");
            string Email= Exceptions.AntiEMptyorNull();
            //acudiente
            Console.Write("Nombre del Acudeinte: ");
            string NombreAcudiente= Exceptions.AntiEMptyorNull();
            //telefono
            Console.Write("Numero de telefono: ");
            string Telefono= Exceptions.AntiEMptyorNull();
            //telefono
            Console.Write("Curso Actual: ");
            string CursoActual= Exceptions.AntiEMptyorNull().ToUpper();
        }
        public static void CreateVehicle(){}
        public static void Createcustomer(){}
        

             //   recorrido de listas en busquedas     profesores
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
            
            //fecha
            int dia= Exceptions.safeInt("Dia de Nacimiento: ");
            int month= Exceptions.safeInt("Mes de Nacimiento: " );
            int year= Exceptions.safeInt("Año de Nacimiento: ");
            
            
           

            Console.WriteLine(" oprima cualquier boton para volver al menu...");
            Console.ReadKey();
            
        } 
        //creacion nuevo profesor
        public static  void NuevoProfesor(){
            Title("Nuevo Profesor",ConsoleColor.DarkGreen);
            //nombre
            Console.Write("Nombre del Profesor: ");
            string Nombre= Exceptions.AntiEMptyorNull();
            //apellido
            Console.Write("Apellido: ");
            string Apellido= Exceptions.AntiEMptyorNull();
            //tipo de docuemto
            Console.Write("Tipo de Documento: ");
            string TipoDocumento= Exceptions.AntiEMptyorNull();
            //numero de docuemto
            Console.Write("Numero de Documento: ");
            string NumeroDocumento= Exceptions.AntiEMptyorNull();
        // email
            Console.Write("Email: ");
            string Email= Exceptions.AntiEMptyorNull();
            //acudiente
            Console.Write("Nombre del Acudeinte: ");
            string Asignatura= Exceptions.AntiEMptyorNull();
            //telefono
            Console.Write("Numero de telefono: ");
            string Telefono= Exceptions.AntiEMptyorNull();
            //Salario
            double Salario= Exceptions.safeDouble("Salario");
            //fecha de contratacion
            int dia= Exceptions.safeInt("Dia decontratacion: ");
            int month= Exceptions.safeInt("Mes de contratacion " );
            int year= Exceptions.safeInt("Año decontratacion: ");

            AdministradorApp.Profesores.Add(new Profesor(Nombre,Apellido,TipoDocumento,NumeroDocumento,Email,Telefono,Asignatura,Salario,dia,month,year));
            
            GreenText("Nuevo Profesor registrado satisfactoriamente");

            Console.WriteLine(" oprima cualquier boton para volver al menu...");
            Console.ReadKey();
            StudentMEnu();
        } 

     public static void EditarNombrePRofesor(){
        Uti.Title("Editar Profesor",ConsoleColor.Cyan);
        Console.Write("Documento Del profesor ");
            string Documento= Exceptions.AntiEMptyorNull();
            Console.Write("Nombre del Profesor: ");
            string NuevoNombre= Exceptions.AntiEMptyorNull();
            Profesor.editarNombre(Documento,NuevoNombre);
     }
        

        
    }
}