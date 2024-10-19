using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project3_api.Models_Tables_;

namespace project3_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Product_tableController : ControllerBase
    {
        private readonly ProductDbContext _context;

        public Product_tableController(ProductDbContext context)
        {
            _context = context;
        }

        // GET: api/Product_table
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product_table>>> GetProduct_Tables()
        {
            return await _context.Product_Tables.ToListAsync();
        }

        // GET: api/Product_table/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product_table>> GetProduct_table(int id)
        {
            var product_table = await _context.Product_Tables.FindAsync(id);

            if (product_table == null)
            {
                return NotFound();
            }

            return product_table;
        }

        // PUT: api/Product_table/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct_table(int id, Product_table product_table)
        {
            if (id != product_table.productId)
            {
                return BadRequest();
            }

            _context.Entry(product_table).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Product_tableExists(id))
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

        // POST: api/Product_table
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product_table>> PostProduct_table(Product_table product_table)
        {
            _context.Product_Tables.Add(product_table);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct_table", new { id = product_table.productId }, product_table);
        }

        // DELETE: api/Product_table/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct_table(int id)
        {
            var product_table = await _context.Product_Tables.FindAsync(id);
            if (product_table == null)
            {
                return NotFound();
            }

            _context.Product_Tables.Remove(product_table);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Product_tableExists(int id)
        {
            return _context.Product_Tables.Any(e => e.productId == id);
        }
    }
}
