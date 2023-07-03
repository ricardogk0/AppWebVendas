using System.Collections.Generic;

namespace MyFirstAppWeb.Models

{
    public class Vendedor
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double SalarioBase { get; set; }

        public Vendedor(int codigo, string nome, double salarioBase)
        {
            Codigo = codigo;
            Nome = nome;
            SalarioBase = salarioBase;
        }

        public Vendedor()
        {

        }
    }
}
