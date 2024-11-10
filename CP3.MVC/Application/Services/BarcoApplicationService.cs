using CP3.MVC.Application.Dtos;
using CP3.MVC.Domain.Entities;
using CP3.MVC.Domain.Interfaces;
using CP3.MVC.MVC.Application.Interfaces;
using System.Collections.Generic;

namespace CP3.MVC.Application.Services
{
    public class BarcoApplicationService : IBarcoApplicationService
    {
        private readonly IBarcoRepository _repository;

        public BarcoApplicationService(IBarcoRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<BarcoEntity> ObterTodosBarcos()
        {
            return _repository.ObterTodos();
        }

        public BarcoEntity? ObterBarcoPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public BarcoEntity? AdicionarBarco(BarcoDto dto)
        {
            var barco = new BarcoEntity
            {
                Nome = dto.Nome,
                Modelo = dto.Modelo,
                Ano = dto.Ano,
                Tamanho = dto.Tamanho
            };
            return _repository.Adicionar(barco);
        }

        public BarcoEntity? EditarBarco(int id, BarcoDto dto)
        {
            var barco = _repository.ObterPorId(id);
            if (barco == null) return null;

            barco.Nome = dto.Nome;
            barco.Modelo = dto.Modelo;
            barco.Ano = dto.Ano;
            barco.Tamanho = dto.Tamanho;
            return _repository.Editar(barco);
        }

        public BarcoEntity? RemoverBarco(int id)
        {
            return _repository.Remover(id);
        }
    }
}