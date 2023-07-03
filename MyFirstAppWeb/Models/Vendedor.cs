using System.Collections.Generic;
using System.Linq;

namespace MyFirstAppWeb.Models

{
    public class Vendedor
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double SalarioBase { get; set; }
        public ICollection<Venda> vendas { get; set; } = new List<Venda>();

        public Vendedor() { }

        public Vendedor(int id, int codigo, string nome, double salarioBase)
        {
            Id = id;
            Codigo = codigo;
            Nome = nome;
            SalarioBase = salarioBase;
        }

        public void AddVenda(Venda v)
        {
            vendas.Add(v);
        }

        public void RemoveVenda(Venda v)
        {
            vendas.Remove(v);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return vendas.Where(v => v.Data >= inicial && v.Data <= final).Sum(v => v.Valor);
        }

    }
}
