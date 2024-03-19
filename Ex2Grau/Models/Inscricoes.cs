using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ex2Grau.Models
{
    [PrimaryKey(nameof(UCFK), nameof(AlunoFK))]
    public class Inscricoes
    {
        public DateTime DataInscricao { get; set; }

        
        [ForeignKey(nameof(UC))]
        //[Key]

        public int UCFK { get; set; }
        public UnidadesCurriculares UC { get; set; }

        [ForeignKey(nameof(Aluno))]
        //[Key]

        public int AlunoFK { get; set; }

        public Alunos Aluno { get; set; }
    }
}
