using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppBanco.Models
{
    [Table("tb_usuario")]
    public class Usuario
    {
        [Display(Name = "Código")]
        [Column("Codigo")]
        public int Id { get; set; }

        [Display(Name = "Nome Usuário")]
        [Column("Nome")]
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string? Nome { get; set; }
        
    }
}
