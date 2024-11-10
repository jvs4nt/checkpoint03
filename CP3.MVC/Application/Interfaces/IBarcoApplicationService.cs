using CP3.MVC.Application.Dtos;
using CP3.MVC.Domain.Entities;

namespace CP3.MVC.MVC.Application.Interfaces
{
    public interface IBarcoApplicationService
    {
        IEnumerable<BarcoEntity> ObterTodosBarcos();
        BarcoEntity ObterBarcoPorId(int id);
        BarcoEntity AdicionarBarco(BarcoDto entity);
        BarcoEntity EditarBarco(int id, BarcoDto entity);
        BarcoEntity RemoverBarco(int id);

    }
}
