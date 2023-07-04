using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyFirstAppWeb.Models
{
    public class Item
    {
        [Key]
        public int Id_item { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Item() { }

        public Item(int id, string codigo, string descricao, double preco)
        {
            Id_item = id;
            Codigo = codigo;
            Descricao = descricao;
            this.Preco = preco;
        }
    }
}
