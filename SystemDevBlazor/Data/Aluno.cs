using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemDevBlazor.Data
{
    [Table("alunos")]
    public class Aluno
    {
        [Column("matricula")]
        [Key]    
        public int Matricula { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("data_nascimento")]
        public DateTime DataNascimento { get; set; }
        [Column("email")]
        public string Email { get; set; }

        public List<Nota> Notas { get; set; }
    }
}
