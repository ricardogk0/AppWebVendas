using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstAppWeb.Models
{
    [Table("venda")]
    public class Venda
    {
        [Key]
        [Column("id_venda")]
        public int IdVenda { get; set; }
        [Column("numero_cupom")]
        public string Numero_Cupom { get; set; }
        [Column("item_venda")]
        public List<ItemVenda> ItemVenda { get; set; }
        [Column("cod_vendedor")]
        public int CodVendedor { get; set; }
        [Column("cod_cliente")]
        public int CodCliente { get; set; }
        [Column("valor_total")]
        public double ValorTotal { get; set; }
        [Column("data")]
        public DateTime Data { get; set; }
    }
}
