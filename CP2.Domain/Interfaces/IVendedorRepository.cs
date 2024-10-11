using CP2.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CP2.Domain.Interfaces
{
    public interface IVendedorRepository
    {
        Task<VendedorEntity> AddAsync(VendedorEntity vendedor);
        Task<IEnumerable<VendedorEntity>> GetAllAsync();
        Task<VendedorEntity> GetByIdAsync(int id);
        Task UpdateAsync(VendedorEntity vendedor);
        Task DeleteAsync(int id);
    }
}
