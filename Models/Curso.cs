using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        
        
        [Required]
        public string Nome { get; set; }
        [Required]

        public string Descricao { get; set; }
        [Required]
        public string Duracao { get; set; }
        public int FormacaoId { get; set; }
        public Formacao Formacao { get; set; }
        
        
        
        
        
        
        
        
        
        
    }
}