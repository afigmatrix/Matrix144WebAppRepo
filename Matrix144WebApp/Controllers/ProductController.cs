using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Matrix144WebApp.DAL;
using Matrix144WebApp.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Matrix144WebApp.Controllers
{
    [ApiController]
    [Route("/api/[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Product> allProducts = await _context.Products.ToListAsync();
            return Ok(allProducts);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(Product product)
        {
            var productEntity = await _context.Products.FindAsync(product.Id);

            if (productEntity == null)
            {
                throw new Exception("Product not fount");
            }

            productEntity.Code = product.Code;
            productEntity.Description = product.Description;
            productEntity.IsActive = product.IsActive;

            _context.Products.Update(productEntity);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var productEntity = await _context.Products.FindAsync(id);

            if (productEntity == null)
            {
                throw new Exception("Product not found");
            }

            _context.Products.Remove(productEntity);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
