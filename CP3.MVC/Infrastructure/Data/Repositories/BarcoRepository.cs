using CP3.MVC.Domain.Entities;
using CP3.MVC.Domain.Interfaces;
using CP3.MVC.Infrastructure.Data.AppData;
using System.Collections.Generic;
using System.Linq;

namespace CP3.MVC.Infrastructure.Data.Repositories
{
    public class BarcoRepository : IBarcoRepository
    {
        private readonly ApplicationContext _context;

        public BarcoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public BarcoEntity? ObterPorId(int id)
        {
            return _context.Barco.Find(id);
        }

        public IEnumerable<BarcoEntity>? ObterTodos()
        {
            return _context.Barco.ToList();
        }

        public BarcoEntity? Adicionar(BarcoEntity barco)
        {
            _context.Barco.Add(barco);
            _context.SaveChanges();
            return barco;
        }

        public BarcoEntity? Editar(BarcoEntity barco)
        {
            var existingBarco = _context.Barco.Find(barco.Id);
            if (existingBarco == null) return null;

            existingBarco.Nome = barco.Nome;
            existingBarco.Modelo = barco.Modelo;
            existingBarco.Ano = barco.Ano;
            existingBarco.Tamanho = barco.Tamanho;

            _context.SaveChanges();
            return existingBarco;
        }

        public BarcoEntity? Remover(int id)
        {
            var barco = _context.Barco.Find(id);
            if (barco == null) return null;

            _context.Barco.Remove(barco);
            _context.SaveChanges();
            return barco;
        }
    }
}