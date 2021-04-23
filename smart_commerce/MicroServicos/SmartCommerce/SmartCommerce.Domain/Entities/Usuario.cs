using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCommerce.Domain.Entities
{
    [Table("TB_USUARIO")]
    public class Usuario : BaseEntity
    {
        [Column("ID_USUARIO")]
        public new int Id { get; set; }

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
