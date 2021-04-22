using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCommerceAPI.Model
{
    [Table("T_LOCAL")]
    public class Local
    {
        [Column("ID_LOCAL")]
        public int IdLocal { get; set; }
        
        [Column("ID_SEGMENTO_ID_SEGMENTO")]
        public int IdSegmento { get; set; }
        
        [Column("T_USUARIO_ID_USUARIO")]
        public int IdUsuario { get; set; }
        
        [Column("NOME")]
        public string Nome { get; set; }
        
        [Column("CEP")]
        public int Cep { get; set; }
        
        [Column("LATITUDE")]
        public double Latitude { get; set; }

        [Column("LONGITUDE")]
        public double Longitude { get; set; }

        [Column("LONGRADOURO")]
        public string Longradouro { get; set; }

        [Column("NUMERO")]
        public int Numero { get; set; }

        [Column("BAIRRO")]
        public string Bairro { get; set; }

        [Column("CIDADE")]
        public string Cidade { get; set; }

        [Column("UF")]
        public string Uf { get; set; }

        [Column("COMPLEMENTO")]
        public string Complemento { get; set; }

        [Column("DATA_CADASTRO")]
        public DateTime DataCadastro { get; set; }
    }
}
