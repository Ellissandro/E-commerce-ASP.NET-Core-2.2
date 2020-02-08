using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        /*
         * Nome: Informática
         * URL normal: www.lojavirutal.com.br/categoria/5 
         * URl Amigavél e com Slug: www.lojavirutal.com.br/categoria/informatica (Url amigavel)
         * Slug:
         */
         
        public string Slug { get; set; }

        /*
         * Auto-Relacionamento 
         * 1-Informática - P: null
         * - 2-Mouse P:1
         * -- 3-Mouse sem fio P:2
         * -- 4-Mouse Gamer P:2
         */

        public int? CategoriaPaiId { get; set; }

        /*
         * ORm - EntityFrameworkCore
         */
         [ForeignKey("CategoriaPaiId")]
         public virtual Categoria CatetegoriaPai { get; set; }
    }
}
