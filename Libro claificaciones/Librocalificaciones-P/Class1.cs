using System;
using System.Collections.Generic;
using System.Text;

namespace Librocalificaciones_P
{
    public class LibroCalificaciones
    {
        private string nombreCurso; //nombre del curso que representa este LibroCalificaciones

        //el constructor inicializa nombreCurso
        public LibroCalificaciones(string nombre)
        {
            nombreCurso = nombre; // inicializa nombreCurso usando la propiedad
        }//fin del consrtuctor

        //propiedad para obtener (get) y establecer (set) el nombre del curso

        public string NombreCurso
        {
            get
            {
                return nombreCurso; 
            }//fin del get
            set
            {
                nombreCurso = value;//set deberia validar
            }//fin del set

        }//fin de la propiedad NombreCiurso

        //muestra mensaje de vienvenida para el usuario de LibroCalificaciones
        public void MostrarMensaje()
        {
            //la propiedad NombreCurso obtiene el nombre del cursoç
            Console.WriteLine("Bienvenido al libro de calificaciones de\n{0}!", NombreCurso);
        }//fin del metodo mostrar mensaje

        //determina el promedio de la clase con base en las 10 calificaciones introducidas por el usuario
        public void DeterminarPromedioClase()
        {
            int total;//suma de las calificaciones instroducidas por el usuario
            int contadorCalif; //numero de la siguiente claificacion a introducir
            int calificacion; //valor de la calificacion intoducida por el usuario 
            int promedio; //promedio de las calificaciones

            //fase de inicializacion

            total = 0; //inicializa el total
            contadorCalif = 1;//inicializa el contador del ciclo
            
            //fase de procesamiento
            while (contadorCalif <= 10)//itera 10 veces
            {
                Console.WriteLine ("escriba calificacion: ");//mensaje para el usuario
                calificacion = Convert.ToInt32(Console.ReadLine());//lee calificaion 
                total = total + calificacion;//suma de calificacion al total
                contadorCalif = contadorCalif + 1;//incrementa le contador en 1
            }//fin de while
            promedio = total / 10;

            Console.WriteLine("\nEl total de las 10 calificaciones es {0}", total);
            Console.WriteLine("El promedio de la clase en {0}", promedio);
        }//fin
    }
}
