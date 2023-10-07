using Negocio.Entidades;

namespace Negocio.Repository
{
    public interface IFornecedorRepository
    {
        List<Fornecedor> ObterTodos();
    }
}
