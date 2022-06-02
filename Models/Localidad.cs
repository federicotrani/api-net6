using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api_net6.Models
{
    [Table("localidades")]
    public class Localidad
    {   
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("nombre")]
        [Required]
        [StringLength(maximumLength:200, ErrorMessage = "La longitud maxima de campo {0} es de {1} caracteres.")]
        public string Nombre { get; set; }     
    }
}