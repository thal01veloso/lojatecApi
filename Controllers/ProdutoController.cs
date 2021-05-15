using System.Collections.Generic;
using System.Linq;
using livrariaApi.Context;
using livrariaApi.Entity;
using Microsoft.AspNetCore.Mvc;

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
        public List<Produto> GetAll()
        {
            return _context.Produtos.ToList();
        }

    }
}