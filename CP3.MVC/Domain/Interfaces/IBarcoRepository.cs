using CP3.MVC.Domain.Entities;

namespace CP3.MVC.Domain.Interfaces
{
    public interface IBarcoRepository
    {
        BarcoEntity? ObterPorId(int id);
        IEnumerable<BarcoEntity>? ObterTodos();
        BarcoEntity? Adicionar(BarcoEntity cliente);
        BarcoEntity? Editar(BarcoEntity cliente);
        BarcoEntity? Remover(int id);

    }
}
