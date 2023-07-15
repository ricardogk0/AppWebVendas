using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstAppWeb.Models

{
    [Table("item_venda")]
    public class ItemVenda
    {
        [Key]
        [Column("id_item_venda")]
        public int IdItemVenda { get; set; }
        [Column("cod_item")]
        public int CodItem { get; set; }
        [Column("quantidade")]
        public double Quantidade { get; set; }  
    }
}
