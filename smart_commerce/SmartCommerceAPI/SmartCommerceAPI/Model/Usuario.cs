using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCommerceAPI.Model
{
    [Table("TB_USUARIO")]
    public class Usuario
    {
        [Column("ID_USUARIO")]
        public int Id { get; set; }

        [Column("NOME")]
        public string NomeCliente { get; set; }

        [Column("SOBRENOME")]
        public string Sobrenome { get; set; }

        [Column("DATA_CADASTRO")]
        public DateTime DataCadastro { get; set; }

        [Column("STATUS")]
        public char Status { get; set; }
    }
}
