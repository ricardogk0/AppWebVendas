namespace MyFirstAppWeb.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }

        public Venda() { }

        public Venda(int id, Item item, Vendedor vendedor, Cliente cliente, double valor, DateTime data)
        {
            Id = id;
            Item = item;
            Vendedor = vendedor;
            Cliente = cliente;
            Valor = valor;
            Data = data;
        }
    }
}
