using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemDevBlazor.Data
{
    public class Disciplina
    {

        [Column("id")]
        [Key]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("professor")]
        public string Professor { get; set; }
        [Column("quantNotas")]
        public int QuantNotas { get; set; }
        [Column("localidade")]
        public string Localidade { get; set; }
        [Column("sala")]
        public int Sala { get; set; }
        [Column("idAluno")]
        public int IdAluno { get; set; }

        public List<Nota> Notas { get; set; }

    }
}
