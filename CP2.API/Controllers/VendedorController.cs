using CP2.Application.Dtos;
using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace CP2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedorController : ControllerBase
    {
        private readonly IVendedorService _applicationService;

        public VendedorController(IVendedorService applicationService)
        {
            _applicationService = applicationService;
        }

        /// <summary>
        /// </summary>
        /// <returns>Lista de vendedores.</returns>
        /// <response code="200">Retorna a lista de vendedores.</response>
        /// <response code="400">Falha ao obter vendedores.</response>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<VendedorEntity>), 200)]
        [ProducesResponseType(typeof(string), 400)]
        public async Task<IActionResult> Get()
        {
            var objModel = await _applicationService.ObterTodosVendedores();

            if (objModel is not null)
                return Ok(objModel);

            return BadRequest("Não foi possível obter os dados.");
        }

        /// <summary>
        /// </summary>
        /// <param name="id">ID do vendedor.</param>
        /// <returns>Dados do vendedor.</returns>
        /// <response code="200">Retorna o vendedor.</response>
        /// <response code="400">Falha ao obter o vendedor.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(VendedorEntity), 200)]
        [ProducesResponseType(typeof(string), 400)]
        public async Task<IActionResult> GetPorId(int id)
        {
            var objModel = await _applicationService.ObterVendedorPorId(id);

            if (objModel is not null)
                return Ok(objModel);

            return BadRequest("Não foi possível obter os dados.");
        }

        /// <summary>
        /// </summary>
        /// <param name="entity">Dados do vendedor a ser cadastrado.</param>
        /// <returns>Vendedor cadastrado.</returns>
        /// <response code="200">Vendedor cadastrado com sucesso.</response>
        /// <response code="400">Falha ao cadastrar vendedor.</response>
        [HttpPost]
        [ProducesResponseType(typeof(VendedorEntity), 200)]
        [ProducesResponseType(typeof(object), 400)]
        public async Task<IActionResult> Post([FromBody] VendedorDto entity)
        {
            try
            {
                var objModel = await _applicationService.AddAsync(new VendedorEntity { /* Mapeie os dados do DTO para a entidade aqui */ });

                if (objModel is not null)
                    return Ok(objModel);

                return BadRequest("Não foi possível salvar os dados.");
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Error = ex.Message,
                    status = HttpStatusCode.BadRequest,
                });
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="id">ID do vendedor a ser atualizado.</param>
        /// <param name="entity">Novos dados do vendedor.</param>
        /// <returns>Vendedor atualizado.</returns>
        /// <response code="200">Vendedor atualizado com sucesso.</response>
        /// <response code="400">Falha ao atualizar vendedor.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(VendedorEntity), 200)]
        [ProducesResponseType(typeof(object), 400)]
        public async Task<IActionResult> Put(int id, [FromBody] VendedorDto entity)
        {
            try
            {
                var vendedor = new VendedorEntity { /* Mapeie os dados do DTO para a entidade aqui */ };
                vendedor.Id = id; // Certifique-se de que o ID está correto

                await _applicationService.UpdateAsync(vendedor);

                return Ok(vendedor);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Error = ex.Message,
                    status = HttpStatusCode.BadRequest,
                });
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="id">ID do vendedor a ser removido.</param>
        /// <returns>Status da operação de remoção.</returns>
        /// <response code="200">Vendedor removido com sucesso.</response>
        /// <response code="400">Falha ao remover vendedor.</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(string), 400)]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _applicationService.DeleteAsync(id);

                
                return Ok("Vendedor removido com sucesso.");
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Error = ex.Message,
                    status = HttpStatusCode.BadRequest,
                });
            }
        }

    }
}
