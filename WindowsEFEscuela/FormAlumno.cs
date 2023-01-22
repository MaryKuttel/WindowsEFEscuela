using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFEscuela.Modelos;
using WindowsEFEscuela.Dac;

namespace WindowsEFEscuela
{
    public partial class FormAlumno : Form
    {
        public FormAlumno()
        {
            InitializeComponent();
        }

        private void bttnInsertarAlumno_Click(object sender, EventArgs e)
        {
            Profesor profesorNew = new Profesor() { Nombre = "Antonio", Apellido = "Banderas", Titulo = "Docente" };
            Alumno alumnoNuevo = new Alumno() { Nombre = textNombre.Text, Apellido = textApellido.Text, FechaNacimiento = Convert.ToDateTime(dateNacimiento.Value), Profesor = profesorNew };

            int filasAfectadas = ABMAlumno.Insert(alumnoNuevo);
            if(filasAfectadas > 0)
            {
                MessageBox.Show("Alumno Insertado Correctamente.");
                MostrarAlumnos();
            }
        }

        private void gridAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAlumno_Load(object sender, EventArgs e)
        {
            MostrarAlumnos();
        }

        public void MostrarAlumnos()
        {
            gridAlumnos.DataSource = ABMAlumno.SelectAll();
        }

        private void modfAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno()
            {
                AlumnoId = Convert.ToInt32(textIdAlumno),
                Nombre = textNombre.Text,
                Apellido = textApellido.Text,
                FechaNacimiento = Convert.ToDateTime(dateNacimiento.Value)
            };
            
            int filasAfectadas = ABMAlumno.Update(alumno);
            if(filasAfectadas > 0)
            {
                MessageBox.Show("Alumno Actualizado Correctamente.");
                MostrarAlumnos();
            }
        }

        private void traerAlumnID_Click(object sender, EventArgs e)
        {
            int idBuscar = Convert.ToInt32(textIdAlumno.Text);
            Alumno alumnoFind = ABMAlumno.SelectWhereById(idBuscar);
            MessageBox.Show(alumnoFind.Nombre);
        }

        private void traerTodosAlumn_Click(object sender, EventArgs e)
        {
            ABMAlumno.SelectAll();
            MostrarAlumnos();
        }

        private void eliminarAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumnoDelete = new Alumno()
            {
                AlumnoId = Convert.ToInt32(textIdAlumno),
                Nombre = textNombre.Text,
                Apellido = textApellido.Text,
                FechaNacimiento = Convert.ToDateTime(dateNacimiento.Value)
            };

            int filasAfectadas = ABMAlumno.Delete(alumnoDelete);

            if(filasAfectadas > 0)
            {
                MessageBox.Show("Alumno Eliminado Correctamente");
                MostrarAlumnos();
            }
        }
    }
}
