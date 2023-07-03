namespace MyFirstAppWeb.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cpf_Cnpj { get; set; }
        public int TipoCliente { get; set; }

        public Cliente(string nome, string email, string telefone, string cpf_Cnpj, int tipoCliente)
        {
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
