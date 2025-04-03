using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProjetoJogos.Domains
{
    [Table("Usuario")]
    [Index(nameof(Nickname), IsUnique = true)]
    public class Usuario
    {
        [Key]
        public Guid UsuarioID { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O nome eh obrigatorio")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O Username eh obrigatorio")]
        public string? Nickname { get; set; }
        
        public Guid JogoFavorito { get; set; }
        [ForeignKey("JogoFavorito")]
        public Jogos? Jogo { get; set; }
    }
}
