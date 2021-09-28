using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EstoqueProdutoApi.Business.Entities;
using EstoqueProdutoApi.Infra.Data;

namespace EstoqueProdutoApi.Controllers
{
    [Route("api/v1/contaacesso")]
    [ApiController]
    public class ContaAcessoController : ControllerBase
    {
        private readonly EstoqueProdutoApiDbcontext _context;

        public ContaAcessoController(EstoqueProdutoApiDbcontext context)
        {
            _context = context;
        }

        // GET: api/ContaAcesso
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContaAcesso>>> GetContaAcessos()
        {
            return await _context.ContaAcessos.ToListAsync();
        }

        // GET: api/ContaAcesso/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContaAcesso>> GetContaAcesso(int id)
        {
            var contaAcesso = await _context.ContaAcessos.FindAsync(id);

            if (contaAcesso == null)
            {
                return NotFound();
            }

            return contaAcesso;
        }

        // PUT: api/ContaAcesso/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContaAcesso(int id, ContaAcesso contaAcesso)
        {
            if (id != contaAcesso.ContaAcessoID)
            {
                return BadRequest();
            }

            _context.Entry(contaAcesso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContaAcessoExists(id))
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

        // POST: api/ContaAcesso
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ContaAcesso>> PostContaAcesso(ContaAcesso contaAcesso)
        {
            _context.ContaAcessos.Add(contaAcesso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContaAcesso", new { id = contaAcesso.ContaAcessoID }, contaAcesso);
        }

        // DELETE: api/ContaAcesso/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContaAcesso(int id)
        {
            var contaAcesso = await _context.ContaAcessos.FindAsync(id);
            if (contaAcesso == null)
            {
                return NotFound();
            }

            _context.ContaAcessos.Remove(contaAcesso);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContaAcessoExists(int id)
        {
            return _context.ContaAcessos.Any(e => e.ContaAcessoID == id);
        }
    }
}
