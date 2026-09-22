# Laboratorio — Instrucciones de Control en C#

**Fecha:** 21/9/2026

## Contenido del Repositorio

Este laboratorio corresponde al curso **Herramientas de la Programación Aplicada III (.Net)**. Se desarrollaron dos versiones de una aplicación de consola llamada **Libro de Calificaciones**, cuyo objetivo es practicar el uso de instrucciones de control (`while`, `if/else`) para acumular y promediar calificaciones ingresadas por el usuario, partiendo de un ciclo contado con un número fijo de iteraciones hasta llegar a un ciclo controlado por un valor centinela.

## Tecnologías Utilizadas

- **Lenguaje / Framework:** C# — .NET 10.0 (aplicaciones de consola)
- **IDE:** Visual Studio

## Ejercicios

- **Ejercicio 1 — `Librocalificaciones-P`:** Clase `LibroCalificaciones` con constructor y propiedad `NombreCurso`. El método `DeterminarPromedioClase()` usa un ciclo `while` controlado por contador que solicita exactamente **10 calificaciones**, las suma y calcula el promedio con división entera.
- **Ejercicio 2 — `Librocalificaciones_P2`:** Misma estructura de clase, pero `DeterminarPromedioClase()` usa un ciclo `while` controlado por **valor centinela** (`-1` para salir), permitiendo ingresar una cantidad variable de calificaciones. El promedio se calcula como `double` con dos decimales de precisión, y se valida con un `if/else` que no se hayan introducido calificaciones antes de dividir.

## Estructura de Carpetas

```
Libro Calificaciones/
├── Librocalificaciones-P/     # Ejercicio 1: ciclo controlado por contador (10 calificaciones)
│   ├── Program.cs
│   └── Class1.cs
├── Librocalificaciones_P2/    # Ejercicio 2: ciclo controlado por centinela (-1)
    ├── Program.cs
    └── Class1.cs
```

## Autor y Contexto

- **Nombre:** Kankibe
- **Institución:** Universidad Tecnológica de Panamá (UTP)
- **Curso:** Herramientas de la Programación Aplicada III (.Net)
- **Fecha de Realización:** 21/9/2026
