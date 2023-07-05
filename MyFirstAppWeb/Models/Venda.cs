using System.ComponentModel.DataAnnotations;

namespace MyFirstAppWeb.Models
{
    public class Venda
    {
        [Key]
        public int IdVenda { get; set; }
        public string Numero_Cupom { get; set; }
        public List<ItemVenda> ItemVenda { get; set; }
        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }
        public double ValorTotal { get; set; }
        public DateTime Data { get; set; }

        public Venda() { }

        public Venda( string numero_Cupom, List<ItemVenda> itemVenda, Vendedor vendedor, Cliente cliente, double valorTotal, DateTime data)
        {
            Numero_Cupom = numero_Cupom;
            ItemVenda = itemVenda;
            Vendedor = vendedor;
            Cliente = cliente;
            ValorTotal = valorTotal;
            Data = data;
        }
    }
}
