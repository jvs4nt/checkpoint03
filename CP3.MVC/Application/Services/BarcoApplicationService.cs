using CP3.MVC.Application.Dtos;
using CP3.MVC.Domain.Entities;
using CP3.MVC.Domain.Interfaces;
using CP3.MVC.MVC.Application.Interfaces;

namespace CP3.MVC.Application.Services
{
    public class BarcoApplicationService : IBarcoApplicationService
    {
        private readonly IBarcoRepository _repository;

        public BarcoApplicationService(IBarcoRepository repository)
        {
            _repository = repository;
        }
    }
}
