using CP2.Application.Dtos;
using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CP2.Application.Services
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public async Task<FornecedorEntity> AddAsync(FornecedorEntity fornecedor)
        {
            return await _fornecedorRepository.AddAsync(fornecedor);
        }

        public async Task<IEnumerable<FornecedorEntity>> GetAllAsync()
        {
            return await _fornecedorRepository.GetAllAsync();
        }

        public async Task<FornecedorEntity> GetByIdAsync(int id)
        {
            return await _fornecedorRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(FornecedorEntity fornecedor)
        {
            await _fornecedorRepository.UpdateAsync(fornecedor);
        }

        public async Task DeleteAsync(int id)
        {
            await _fornecedorRepository.DeleteAsync(id);
        }

        public async Task<FornecedorEntity> ObterFornecedorPorId(int id)
        {
            return await GetByIdAsync(id);
        }

        public async Task<IEnumerable<FornecedorEntity>> ObterTodosFornecedores()
        {
            return await GetAllAsync();
        }
    }
}
