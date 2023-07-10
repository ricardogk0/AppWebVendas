using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace MyFirstAppWeb.Models

{
    public class Vendedor
    {
        [Key]
        public int Id_Vendedor { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double SalarioBase { get; set; }
        public ICollection<Venda> vendas { get; set; } = new List<Venda>();

        public Vendedor() { }

        public Vendedor(int id, int codigo, string nome, double salarioBase)
        {
            Id_Vendedor = id;
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

        

    }
}
