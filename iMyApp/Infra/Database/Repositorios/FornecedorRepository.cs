using Negocio.Entidades;
using Negocio.Repository;

namespace Database.Repositorios
{
    public class FornecedorRepository : IFornecedorRepository
    {
        public List<Fornecedor> ObterTodos()
        {
            return new List<Fornecedor>()
            {
                new Fornecedor
                {
                    Id = 1,
                    Nome = "Fornecedor 1",
                    Telefone = "(11) 9999-9999",
                    Uf = "SP",
                    Cidade = "São Paulo"
                },
                new Fornecedor
                {
                    Id = 2,
                    Nome = "Fornecedor 2",
                    Telefone = "(21) 9999-9999",
                    Uf = "RJ",
                    Cidade = "Rio de Janeiro"
                },
                new Fornecedor
                {
                    Id = 50,
                    Nome = "Fornecedor 50",
                    Telefone = "(81) 9999-9999",
                    Uf = "PE",
                    Cidade = "Recife"
                }
            };
        }
    }
}
