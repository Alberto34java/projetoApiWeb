using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Formacao
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Nome { get; set; }
        
        
    }
}