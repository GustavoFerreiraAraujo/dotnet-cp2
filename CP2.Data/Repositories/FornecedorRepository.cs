using CP2.Data.AppData;
using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CP2.Data.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly ApplicationContext _context;

        public FornecedorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<FornecedorEntity> AddAsync(FornecedorEntity fornecedor)
        {
            await _context.Fornecedor.AddAsync(fornecedor);
            await _context.SaveChangesAsync();
            return fornecedor;
        }

        public async Task<IEnumerable<FornecedorEntity>> GetAllAsync()
        {
            return await _context.Fornecedor.ToListAsync();
        }

        public async Task<FornecedorEntity> GetByIdAsync(int id)
        {
            return await _context.Fornecedor.FindAsync(id);
        }

        public async Task UpdateAsync(FornecedorEntity fornecedor)
        {
            _context.Fornecedor.Update(fornecedor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var fornecedor = await GetByIdAsync(id);
            if (fornecedor != null)
            {
                _context.Fornecedor.Remove(fornecedor);
                await _context.SaveChangesAsync();
            }
        }
    }
}
