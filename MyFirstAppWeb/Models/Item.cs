using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstAppWeb.Models
{
    [Table("item")]
    public class Item
    {
        [Key]
        [Column("id_item")]
        public int Id_item { get; set; }
        [Column("codigo")]
        public string Codigo { get; set; }
        [Column("descricao")]
        public string Descricao { get; set; }
        [Column("preco")]
        public double Preco { get; set; }
    }
}
