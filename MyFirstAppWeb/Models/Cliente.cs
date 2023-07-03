namespace MyFirstAppWeb.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cpf_Cnpj { get; set; }
        public int TipoCliente { get; set; }

        public Cliente(int id, string codigo, string nome, string email, string telefone, string cpf_Cnpj, int tipoCliente)
        {
            Id = id;
            Codigo = codigo;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Cpf_Cnpj = cpf_Cnpj;
            TipoCliente = tipoCliente;
        }

        public Cliente()
        {

        }

    }
}
