using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Athletico.Models
{
    [Table("Produtos")]
    public class Produto
    {
        public Produto() { CriadoEm = DateTime.Now; }
        [Key]

        public int ProdutoId { get; set; }

        public
    }
}
