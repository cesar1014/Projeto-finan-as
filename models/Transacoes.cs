using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financas.models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace Financas.models
    {
        public class Transacoes
        {
            [Key]
            public int id { get; set; }

            [Required]
            public float valor { get; set; }

            [Required]
            public string descricao { get; set; }

            [Required]
            public DateTime data { get; set; }

            [ForeignKey("Categorias")]
            public int CategoriaID { get; set; }

            public Categorias categoria { get; set; }
        }
    }

}
