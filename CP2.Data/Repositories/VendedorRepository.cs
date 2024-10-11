using CP2.Data.AppData;
using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CP2.Data.Repositories
{
    public class VendedorRepository : IVendedorRepository
    {
        private readonly ApplicationContext _context;

        public VendedorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<VendedorEntity> AddAsync(VendedorEntity vendedor)
        {
            await _context.Vendedor.AddAsync(vendedor);
            await _context.SaveChangesAsync();
            return vendedor;
        }

        public async Task<IEnumerable<VendedorEntity>> GetAllAsync()
        {
            return await _context.Vendedor.ToListAsync();
        }

        public async Task<VendedorEntity> GetByIdAsync(int id)
        {
            return await _context.Vendedor.FindAsync(id);
        }

        public async Task UpdateAsync(VendedorEntity vendedor)
        {
            _context.Vendedor.Update(vendedor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var vendedor = await GetByIdAsync(id);
            if (vendedor != null)
            {
                _context.Vendedor.Remove(vendedor);
                await _context.SaveChangesAsync();
            }
        }
    }
}
