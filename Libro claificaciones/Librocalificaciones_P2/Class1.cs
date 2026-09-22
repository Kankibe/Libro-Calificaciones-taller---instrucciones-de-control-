using System;
using System.Collections.Generic;
using System.Text;

namespace Librocalificaciones_P2
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
            double promedio; //promedio de las calificaciones

            //fase de inicializacion

            total = 0; //inicializa el total
            contadorCalif = 0;//inicializa el contador del ciclo

            //fase de procesamiento
            //mensaje para recibir como entrada la calificacion de usuario
            Console.WriteLine("Escriba calificacion o -1 para salir: ");
            calificacion = Convert.ToInt32(Console.ReadLine());

            //itera hasta que se lee el valor centinela del usuario
            while (calificacion != -1)
            {
                total = total + calificacion; // suma calificacion a total
                contadorCalif = contadorCalif + 1;//incrementa el contador

                //mensaje oara recibir como entrada la siguiente calificacin del usuario
                Console.WriteLine("escriba calificacion o -1 para salir: ");
                calificacion = Convert.ToInt32(Console.ReadLine());
            }

            //fase de terminacion
            //si el usuario introdijo cuando menos una calificacion...

            if (contadorCalif != 0)
            {
                //calcular el promedio de todas las calificaciones introducidas
                promedio = (double) total / contadorCalif;

                //muestra el total y el promedia (con dos digitos de presision)
                Console.WriteLine("\nEl promedio de las {0} calificaciones introducidas es {1}", contadorCalif, total);
                Console.WriteLine("El promedio de la clase es {0:F2}", promedio);
            }//fin del if

            else//no se introdijeron calificaciones, entonces mostrar mensaje de error
                Console.WriteLine("no se introdujeron calificaciones");
        }
    }
}
