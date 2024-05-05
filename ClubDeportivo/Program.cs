﻿using System;

namespace ClubDeportivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
           
                // Crear una instancia de GestionClubDeportivo
                GestionClubDeportivo miClub = new GestionClubDeportivo();

                // Crear una instancia de DateTime para la fecha de afiliación
                DateTime FechaAfiliacion = DateTime.Today;

                // Agregar un socio
                miClub.altaSocio("Juan Pérez", "Belgica 1460", "juanperez@gmail.com", "socio", FechaAfiliacion);

                // Agregar un profesor
                Profesor nuevoProfesor = new Profesor("María García", "19hs");
                miClub.Profesores.Add(nuevoProfesor);

                // Crear una instancia de Actividad
                Actividad actividad = new Actividad("Natación", 1500);
                miClub.Actividades.Add(actividad);

        }
    }
}
