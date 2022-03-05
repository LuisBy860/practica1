using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace practica1.Models
{
    public class Estudiantes
    {

        [Key]

        [DatabaseGeneratedOption]
        public int Id { get; set; }
    }
}
