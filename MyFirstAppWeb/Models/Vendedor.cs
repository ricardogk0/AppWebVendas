using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstAppWeb.Models

{
    [Table("vendedores")]
    public class Vendedor
    {
        [Key]
        [Column("id_vendedor")]
        public int Id_Vendedor { get; set; }
        [Column("codigo")]
        public int Codigo { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("salario_base")]
        public double SalarioBase { get; set; }
    }
}
