using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCommerce.Domain.Entities
{
    [Table("T_PRODUTO")]
    public class Produto : BaseEntity
    {
        [Column("ID_PRODUTO")]
        public new int Id { get; set; }

        [Column("NOME")]
        public string Nome { get; set; }

        [Column("DESCRICAO")]
        public string Descricao { get; set; }

        [Column("PRECO_ESTIMADO")]
        public double PrecoEstimado { get; set; }

        [Column("DATA_CADASTRO")]
        public DateTime DataCadastro { get; set; }

        [Column("CODIGO")]
        public int Codigo { get; set; }
    }
}
