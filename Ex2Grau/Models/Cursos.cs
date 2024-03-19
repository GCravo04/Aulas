using System.Collections.ObjectModel;

namespace Ex2Grau.Models
{
    public class Cursos
    {
        public Cursos() {
            ListaUCs = new HashSet<UnidadesCurriculares>();
            ListaAlunos = new HashSet<Alunos>();
        }



        public int Id { get; set; }
        public string Nome { get; set; }
        
        public String Logotipo { get; set;}


        /* ************************************************** 
       *  Vamos criar as Relações  (Fks) com outras tabelas
       */

        //relacionamento com as unidades  curriculares

        public ICollection<UnidadesCurriculares> ListaUCs { get; set; }

        //relacionamento com os alunos

        public ICollection<Alunos> ListaAlunos { get; set; }

    }
}
