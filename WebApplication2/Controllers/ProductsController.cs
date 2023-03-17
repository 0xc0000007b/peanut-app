using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace WebApplication2.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly StoreDbContext _ctx;

    public ProductsController(StoreDbContext ctx)
    {
        _ctx = ctx;
    }

    [HttpGet]
    public async Task<ActionResult<List<ProductEntity>>> GetProducts()
    {
        
        var prods =  await _ctx.Products.ToListAsync();
        return Ok(prods);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProductEntity>> GetProduct(int id)
    {
        return await _ctx.Products.FindAsync(id);
    }
}