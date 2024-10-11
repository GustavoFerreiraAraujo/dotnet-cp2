using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP2.Domain.Entities
{
    [Table("tb_fornecedor")]
    public class FornecedorEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(14)]  
        public string CNPJ { get; set; }

        [MaxLength(200)]
        public string Endereco { get; set; }

        [MaxLength(15)] 
        public string Telefone { get; set; }

        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        public DateTime CriadoEm { get; set; } = DateTime.Now;
    }
}
