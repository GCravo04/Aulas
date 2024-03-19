using System.ComponentModel.DataAnnotations.Schema;

namespace Ex2Grau.Models
{
    public class Inscricoes
    {
        public DateTime DataInscricao { get; set; }


        [ForeignKey(nameof(UC))]

        public int UCFK { get; set; }
        public UnidadesCurriculares UC { get; set; }

        [ForeignKey(nameof(Aluno))]

        public int AlunoFK { get; set; }

        public Alunos Aluno { get; set; }
    }
}
