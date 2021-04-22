using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCommerceAPI.Model
{
    [Table("T_VOTACAO")]
    public class Votacao
    {
        [Column("ID_VOTACAO")]
        public int IdVotacao { get; set; }

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
