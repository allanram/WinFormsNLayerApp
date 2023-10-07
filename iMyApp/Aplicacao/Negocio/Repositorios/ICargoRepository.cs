using Negocio.Entidades;

namespace Negocio.Repositorios
{
    public interface ICargoRepository
    {
        bool Incluir(Cargo cargo);
        bool Atualizar(Cargo cargo);    
        bool Deletar(int cargoId);
        List<Cargo> OterTodos();

    }
}
