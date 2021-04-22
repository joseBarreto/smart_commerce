using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCommerceAPI.Model
{
    [Table("T_PERFIL")]
    public class Perfil
    {
        [Column("ID_PERFIL")]
        public int IdPerfil { get; set; }

        [Column("CODIGO")]
        public int Codigo { get; set; }

        [Column("NOME")]
        public string Nome { get; set; }

        [Column("DESCRICAO")]
        public string Descricao { get; set; }

        [Column("DATA_CADASTRO")]
        public DateTime DataCadastro { get; set; }
    }
}
