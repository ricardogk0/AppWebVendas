using System.ComponentModel.DataAnnotations;

namespace MyFirstAppWeb.Models
{
    public class Venda
    {
        [Key]
        public int id_venda { get; set; }
        public string Numero_Cupom { get; set; }
        public Item Item { get; set; }
        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }
        public double Quantidade { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }

        public Venda() { }

        public Venda(int id_venda, string numero_Cupom, Item item, Vendedor vendedor, Cliente cliente, double quantidade, double valor, DateTime data)
        {
            this.id_venda = id_venda;
            Numero_Cupom = numero_Cupom;
            Item = item;
            Vendedor = vendedor;
            Cliente = cliente;
            Quantidade = quantidade;
            Valor = valor;
            Data = data;
        }
    }
}
