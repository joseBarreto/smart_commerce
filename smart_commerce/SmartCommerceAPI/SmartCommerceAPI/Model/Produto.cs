using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCommerceAPI.Model
{
    [Table("T_PRODUTO")]
    public class Produto
    {
        [Column("ID_PRODUTO")]
        public int IdProduto { get; set; }

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
