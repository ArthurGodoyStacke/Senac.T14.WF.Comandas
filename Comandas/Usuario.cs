
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comandas
{
   public class Usuario
    {
        // propriedades 
        // colunas ta tabela usuários 
        [Key] // chave primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // AI
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;

    }
}
