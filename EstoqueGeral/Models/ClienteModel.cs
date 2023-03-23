
using Microsoft.EntityFrameworkCore;

namespace SistemaEstoque.Models
{
    public class ClienteModel
    {
        public int IdCliente { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? UF { get; set; }
        public string? CEP { get; set; }
        public string? Email { get; set; }
        public int Celular { get; set; }
        public bool Ativo { get; set; }

        public ClienteModel()
        {

        }

        public ClienteModel(int idCliente, string? nome, string? endereco, string? bairro, string? cidade, string? uf, string? cep, string? email, int celular, bool ativo)
        {
            IdCliente = idCliente;
            Nome = nome;
            Endereco = endereco;
            Bairro = bairro;
            Cidade = cidade;
            UF = uf;
            CEP = cep;
            Email = email;
            Celular = celular;
            Ativo = ativo;
        }
    }
}