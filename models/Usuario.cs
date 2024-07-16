using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financas.models
{
    public class Usuario
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string usuario { get; set; }
        [Required]
        public string senha { get; set; }
        [Required]
        public float saldo { get; set; }
    }
}
