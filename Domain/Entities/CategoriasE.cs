using System; 
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
 
namespace Domain.Entities {
    [Table("categorias")]
    public class CategoriasE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int id { get; set; }

        public required string nombre { get; set; }
    }
} 
