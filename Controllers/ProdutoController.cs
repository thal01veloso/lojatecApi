using System.Collections.Generic;
using System.Linq;
using livrariaApi.Context;
using livrariaApi.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace livrariaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoContext _context;
        
        public ProdutoController(ProdutoContext produtoContext)
        {
            _context = produtoContext;
        }

        [HttpGet]
        public List<ProdutoCesta> GetAll()
        {
            return _context.ProdutosCesta.ToList();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProdutoCesta([FromBody] ProdutoCesta produto)
        {
            _context.ProdutosCesta.Add(produto);
            await _context.SaveChangesAsync();
            return Ok(produto);
        }
         [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoCesta>> GetProdutoCesta(int id)
        {
            var produto = await _context.ProdutosCesta.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }
            return produto;
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProdutoCesta>> DeleteProduto(int id)
        {
            var produtos = await _context.ProdutosCesta.FindAsync(id);
            if (produtos == null)
            {
                return NotFound();
            }
            _context.ProdutosCesta.Remove(produtos);
            await _context.SaveChangesAsync();
            return produtos;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ProdutoCesta produto)
        {
            if (id != produto.ProdutoId)
            {
                return BadRequest();
            }
            _context.Entry(produto).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClienteExiste(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }
        private bool ClienteExiste(int id)
        {
            return _context.ProdutosCesta.Any(e => e.ProdutoId == id);
        }

    }
}