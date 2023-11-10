using Negocio.Entidades;
using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositorios
{
    public class FornecedorRepository : IFornecedorRepository
    {
        public List<Fornecedor> ObterTodos()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>
        {
            new Fornecedor
            {
                Id = 1,
                Nome = "Fornecedor A",
                Telefone = "(123) 456-7890",
                Uf = "SP",
                Cidade = "São Paulo"
            },
            new Fornecedor
            {
                Id = 2,
                Nome = "Fornecedor B",
                Telefone = "(987) 654-3210",
                Uf = "RJ",
                Cidade = "Rio de Janeiro"
            },
            new Fornecedor
            {
                Id = 3,
                Nome = "Fornecedor C",
                Telefone = "(555) 123-4567",
                Uf = "MG",
                Cidade = "Belo Horizonte"
            }
        };

            return fornecedores;
        }
    }
    
}
