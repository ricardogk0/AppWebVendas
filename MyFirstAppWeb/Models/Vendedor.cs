using System.Collections.Generic;

namespace MyFirstAppWeb.Models

{
    public class Vendedor
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double SalarioBase { get; set; }

        public Vendedor() { }

        public Vendedor(int id, int codigo, string nome, double salarioBase)
        {
            Id = id;
            Codigo = codigo;
            Nome = nome;
            SalarioBase = salarioBase;
        }

    }
}
