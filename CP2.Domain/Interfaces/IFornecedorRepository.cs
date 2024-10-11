using CP2.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CP2.Domain.Interfaces
{
    public interface IFornecedorRepository
    {
        Task<FornecedorEntity> AddAsync(FornecedorEntity fornecedor);
        Task<IEnumerable<FornecedorEntity>> GetAllAsync();
        Task<FornecedorEntity> GetByIdAsync(int id);
        Task UpdateAsync(FornecedorEntity fornecedor);
        Task DeleteAsync(int id);
    }
}
