using System.ComponentModel.DataAnnotations.Schema;

namespace Ex2Grau.Models
{
    public class Alunos : Utilizadores
    {

        public Alunos() {
        ListaInscricoes = new HashSet<Inscricoes>();
        }
        public int NumAluno { get; set; }

        public decimal Propinas { get; set; }

        public DateTime DataMatricula { get; set; }
        /* ************************************************** 
       *  Vamos criar as Relações  (Fks) com outras tabelas
       */

        //relacionamento do tipo N-1
        [ForeignKey(nameof(Curso))]// Notação que liga cursoFK a Curso
        public int CursoFK { get; set; } // Será a FK (foreign key) para a tabela cursos
        //[ForeignKey(nameof(CursoFK))] fazer isto é exatamente igual pois Curso - CursoFK == CursoFk - Curso
        public Cursos Curso { get; set; }// ao rigor esta instrução

        public ICollection<Inscricoes> ListaInscricoes { get; set; }


    }
}
