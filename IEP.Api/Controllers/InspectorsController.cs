using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IEP.Api.Data;
using IEP.Api.Model.Entities;

namespace IEP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InspectorsController : ControllerBase
    {
        private readonly IEPApiContext _context;

        public InspectorsController(IEPApiContext context)
        {
            _context = context;
        }

        // GET: api/Inspectors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inspector>>> GetInspector()
        {
            return await _context.Inspector.ToListAsync();
        }

        // GET: api/Inspectors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Inspector>> GetInspector(int id)
        {
            var inspector = await _context.Inspector.FindAsync(id);

            if (inspector == null)
            {
                return NotFound();
            }

            return inspector;
        }

        // PUT: api/Inspectors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInspector(int id, Inspector inspector)
        {
            if (id != inspector.Id)
            {
                return BadRequest();
            }

            _context.Entry(inspector).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InspectorExists(id))
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

        // POST: api/Inspectors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Inspector>> PostInspector(Inspector inspector)
        {
            _context.Inspector.Add(inspector);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInspector", new { id = inspector.Id }, inspector);
        }

        // DELETE: api/Inspectors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInspector(int id)
        {
            var inspector = await _context.Inspector.FindAsync(id);
            if (inspector == null)
            {
                return NotFound();
            }

            _context.Inspector.Remove(inspector);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InspectorExists(int id)
        {
            return _context.Inspector.Any(e => e.Id == id);
        }
    }
}
