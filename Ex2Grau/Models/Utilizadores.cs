using System.ComponentModel.DataAnnotations;

namespace Ex2Grau.Models
{
    public class Utilizadores
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateOnly DataNascimento { get; set; }

    }
}
