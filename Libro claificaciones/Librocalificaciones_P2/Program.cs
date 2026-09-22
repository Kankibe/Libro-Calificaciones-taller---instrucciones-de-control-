namespace Librocalificaciones_P2
{
    public class PruebaLibroCalificaciones
    {
        public static void Main(string[] args)
        {
            //crea el objeto miLibroCalificaciones de LibroCalificaciones y 
            //pasa el nombre del curso al constructor
            LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones("CS101 introduccion a la programacion en C#)");

            miLibroCalificaciones.MostrarMensaje();//muestra el mensaje de bienvenida
            miLibroCalificaciones.DeterminarPromedioClase();//encuentra el promedio de las calificacione
        }//fin de main
    }//fin de la clase
}