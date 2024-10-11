using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP2.Domain.Entities
{
    [Table("tb_vendedor")]
    public class VendedorEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(15)]  
        public string Telefone { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [MaxLength(200)]
        public string Endereco { get; set; }

        [Required]
        public DateTime DataContratacao { get; set; }

        [Range(0, 100)]
        public decimal ComissaoPercentual { get; set; }

        [Range(0, double.MaxValue)]
        public decimal MetaMensal { get; set; }

        public DateTime CriadoEm { get; set; } = DateTime.Now;

    }
}
