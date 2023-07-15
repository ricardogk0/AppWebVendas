using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyFirstAppWeb.Enums;

namespace MyFirstAppWeb.Models
{
    [Table("cliente")]
    public class Cliente
    {
        [Key]
        [Column("id_cliente")]
        public int Id_Cliente { get; set; }
        [Column("codigo")]
        public string Codigo { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("telefone")]
        public string Telefone { get; set; }
        [Column("cpf_cnpj")]
        public string Cpf_Cnpj { get; set; }
        [Column("tipo_cliente")]
        public TipoCliente TipoCliente { get; set; }

    }
}
