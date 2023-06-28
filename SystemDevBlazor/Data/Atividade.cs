using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace SystemDevBlazor.Data
{
    public class Atividade
    {

        [Column("id")]
        [Key]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("idDisciplina")]
        public int IdDisc { get; set; }
        [Column("data")]
        public DateTime Data { get; set; }
    }
}
