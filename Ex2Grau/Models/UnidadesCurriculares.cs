using System.ComponentModel.DataAnnotations.Schema;

namespace Ex2Grau.Models
{
    public class UnidadesCurriculares
    {
        //vamos utilizar o entity framework

        public UnidadesCurriculares() { 
        ListaProfessores = new HashSet<Professores>();
        ListaInscricoes = new HashSet<Inscricoes>();
        }


        public int Id { get; set; }

        public string Nome { get; set; }

        public int AnoCurricular { get; set; }

        public int Semestre { get; set; }

        /* ************************************************** 
         *  Vamos criar as Relações  (Fks) com outras tabelas
         */

        //relacionamento do tipo N-1
        [ForeignKey(nameof(Curso))]// Notação que liga cursoFK a Curso
        public int CursoFK { get; set; } // Será a FK (foreign key) para a tabela cursos
        //[ForeignKey(nameof(CursoFK))] fazer isto é exatamente igual pois Curso - CursoFK == CursoFk - Curso
        public Cursos Curso { get; set; }// ao rigor esta instrução


        public ICollection<Professores> ListaProfessores { get; set;}

        public ICollection<Inscricoes> ListaInscricoes { get; set;}
                                         


      

    }
}
