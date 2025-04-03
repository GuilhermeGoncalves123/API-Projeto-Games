using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

// Caminho em que a Classe Jogo esta
namespace ProjetoJogos.Domains
{
    //Public class -> Cria uma classe publica
    [Table("Jogo")]
    [Index(nameof(nomeDoJogo), IsUnique =true)]
    public class Jogos 
    {
        // Preencher os atributos
        [Key]
        public Guid jogoID { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        // O required faz com que seja obrigatorio preencher o campo NomeDoJOgo 
        [Required(ErrorMessage = "O nome do jogo eh obrigatorio")]
        public string? nomeDoJogo {  get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string? Plataforma { get; set; }
    }
}
