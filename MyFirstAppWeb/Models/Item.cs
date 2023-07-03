using System.Collections.Generic;

namespace MyFirstAppWeb.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public double preco { get; set; }

        public Item() { }

        public Item(int id, string codigo, string descricao, double preco)
        {
            Id = id;
            Codigo = codigo;
            Descricao = descricao;
            this.preco = preco;
        }
    }
}
