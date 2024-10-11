using CP2.Domain.Entities;
using CP2.Domain.Interfaces.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CP2.Domain.Interfaces
{
    public interface IVendedorService
    {
        Task<VendedorEntity> AddAsync(VendedorEntity vendedor);
        Task<IEnumerable<VendedorEntity>> GetAllAsync();
        Task<VendedorEntity> GetByIdAsync(int id);
        Task UpdateAsync(VendedorEntity vendedor);
        Task DeleteAsync(int id); 
        Task<VendedorEntity> ObterVendedorPorId(int id);
        Task<IEnumerable<VendedorEntity>> ObterTodosVendedores(); 
    }
}

