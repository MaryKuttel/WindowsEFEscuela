using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Modelos
{
    public class Profesor
    {
        [Key]
        public int ProfesorId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Apellido { get; set; }


        public List<Alumno> ListaAlumnos { get; set; }



        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Titulo { get; set; }

       /* public Profesor(int profesorId, string nombre, string apellido, List<Alumno> alumnos, string titulo)
        {
            ProfesorId = profesorId;
            Nombre = nombre;
            Apellido = apellido;
            ListaAlumnos = alumnos;
            Titulo = titulo;
        }*/

    }
}
