using Miaudoteme.Domain.Interfaces;
using Miaudoteme.Domain.Models;
using Miaudoteme.Infraestrutura.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Miaudoteme.Infraestrutura.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly ApplicationContext _context;
        public AnimalRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Animal> Busca(Expression<Func<Animal, bool>> expression)
        {
            var animal = await _context.Animais.FindAsync(expression);
            return animal;
        }

        public async Task<Animal> BuscaPorId(Guid id)
        {
            var animal = await _context.Animais.FirstOrDefaultAsync(animal => animal.Id == id);
            return animal;
        }

        public async Task<List<Animal>> BuscaTodos()
        {
            return await _context.Animais.ToListAsync();
            
        }

        public async Task<Animal> Criar(Animal entidade)
        {
            await _context.Animais.AddAsync(entidade);
            var result = _context.SaveChanges();
            return result == 1 ? entidade : throw new Exception("Erro ao criar Animal");
        }

        public async Task Deletar(Guid id)
        {
            var animal = await BuscaPorId(id);
            _context.Animais.Remove(animal);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task Editar(Animal entidade)
        {
            _context.Animais.Update(entidade);
            await _context.SaveChangesAsync();
        }
    }
}
