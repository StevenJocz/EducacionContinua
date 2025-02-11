using System; 
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
 
namespace Domain.Entities {
    [Table("inscripciones_cursos")]
    public class InscripcionesCursosE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int id { get; set; }

        public required int persona_id { get; set; }
        public required int curso_id { get; set; }

        public required int estado { get; set; }
        public required DateTime fecha_registro { get; set; }
    }
} 
