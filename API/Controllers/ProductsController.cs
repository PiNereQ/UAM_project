using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Linq;

namespace API.Controllers
{
    public class ProductsController : BaseApiController
    {
        private readonly DataContext _context;
        public ProductsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            Product[] products = _context.Products.ToArray();
            IEnumerable<Product> query = products.OrderBy(Product => Product.Title);
            foreach (Product tempProduct in query){
                Console.WriteLine("{0} - {1}", tempProduct.Title, tempProduct.Description);
            }
            return await _context.Products.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(Guid id)
        {
            return await _context.Products.FindAsync(id);
        }

        
    }
}