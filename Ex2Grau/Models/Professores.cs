namespace Ex2Grau.Models
{
    public class Professores : Utilizadores
    {






        public Professores() { 
         ListaUCs = new HashSet<UnidadesCurriculares>();
        }

        /* ************************************************** 
     *  Vamos criar as Relações  (Fks) com outras tabelas
     */
        // Relacionamento de M-N SEM atributos do relacionamento
        public ICollection<UnidadesCurriculares> ListaUCs { get; set;}

    }
}
