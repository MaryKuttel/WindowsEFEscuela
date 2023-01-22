using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEscuela.Data;
using WindowsEFEscuela.Modelos;

namespace WindowsEFEscuela.Dac
{
    public static class ABMAlumno
    {

        private static DBEscuelaEFContext context = new DBEscuelaEFContext();

        public static List<Alumno> SelectAll()
        {
            return context.Alumnos.ToList();
        }

        public static Alumno SelectWhereById(int id)
        {
            return context.Alumnos.Find(id);

        }

        public static int Insert(Alumno alumno)
        {
            context.Alumnos.Add(alumno);

            return context.SaveChanges();
        }

        public static int Update(Alumno alumno)
        {
            Alumno alumnoInicial = context.Alumnos.Find(alumno.AlumnoId);
            alumnoInicial.Nombre= alumno.Nombre;
            alumnoInicial.Apellido= alumno.Apellido;
            alumnoInicial.FechaNacimiento = alumno.FechaNacimiento;

            return context.SaveChanges();
        }

        public static int Delete(Alumno alumno)
        {
            Alumno alumnoDelete = context.Alumnos.Find(alumno.AlumnoId);
            if(alumnoDelete != null )
            {
                context.Alumnos.Remove(alumnoDelete);
                return context.SaveChanges();
            }

            return 0;
        }

    }

}

