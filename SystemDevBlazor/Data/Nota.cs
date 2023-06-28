using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemDevBlazor.Data
{
    public class Nota
    {

        [Column("id")]
        [Key]
        public int Id { get; set; }
        [Column("matriculaAluno")]
        [ForeignKey("Aluno")]
        public int IdAluno { get; set; }
        [Column("idDisciplina")]
        [ForeignKey("Disciplina")]
        public int IdDisc { get; set; }
        [Column("nota")]
        public float NotaValor { get; set; }
        [Column("peso")]
        public int Peso { get; set; }

        public Aluno Aluno = new Aluno();
        public Disciplina Disciplina = new Disciplina();


    }
}
