using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCommerce.Domain.Entities
{
    [Table("T_VOTACAO")]
    public class Votacao : BaseEntity
    {
        [Column("ID_VOTACAO")]
        public new int Id { get; set; }

        [Column("T_USUARIO_ID_USUARIO")]
        public int IdUsuario { get; set; }

        [Column("T_LOCAL_ID_LOCAL")]
        public int IdLocal { get; set; }

        [Column("VOTO")]
        public char Voto { get; set; }

        [Column("DATA_CADASTRO")]
        public DateTime DataCadastro { get; set; }
    }
}
