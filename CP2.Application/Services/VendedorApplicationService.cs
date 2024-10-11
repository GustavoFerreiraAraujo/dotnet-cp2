using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CP2.Application.Services
{
    public class VendedorService : IVendedorService
    {
        private readonly IVendedorRepository _vendedorRepository;

        public VendedorService(IVendedorRepository vendedorRepository)
        {
            _vendedorRepository = vendedorRepository;
        }

        public async Task<VendedorEntity> AddAsync(VendedorEntity vendedor)
        {
            return await _vendedorRepository.AddAsync(vendedor);
        }

        public async Task<IEnumerable<VendedorEntity>> GetAllAsync()
        {
            return await _vendedorRepository.GetAllAsync();
        }

        public async Task<VendedorEntity> GetByIdAsync(int id)
        {
            return await _vendedorRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(VendedorEntity vendedor)
        {
            await _vendedorRepository.UpdateAsync(vendedor);
        }

        public async Task DeleteAsync(int id)
        {
            await _vendedorRepository.DeleteAsync(id);
        }

        public async Task<VendedorEntity> ObterVendedorPorId(int id)
        {
            return await _vendedorRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<VendedorEntity>> ObterTodosVendedores()
        {
            return await _vendedorRepository.GetAllAsync();
        }
    }
}
