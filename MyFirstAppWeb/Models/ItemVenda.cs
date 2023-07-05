using System.ComponentModel.DataAnnotations;

namespace MyFirstAppWeb.Models

{
    public class ItemVenda
    {
        [Key]
        public int IdItemVenda { get; set; } 
        public int VendaId { get; set; }
        public Item Item { get; set; }
        public double Quantidade { get; set; }
        public Venda Venda { get; set; }    

        public ItemVenda() { }

        public ItemVenda(int idItemVenda, int vendaId, Item item, double quantidade, Venda venda)
        {
            IdItemVenda = idItemVenda;
            VendaId = vendaId;
            Item = item;
            Quantidade = quantidade;
            Venda = venda;
        }
    }
}
