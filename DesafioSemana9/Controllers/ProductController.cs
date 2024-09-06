using AutoMapper;
using DesafioSemana9.Data;
using DesafioSemana9.Data.Dtos;
using DesafioSemana9.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesafioSemana9.Controllers;


[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private ProductContext _context;
    private IMapper _mapper;

    public ProductController(ProductContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddProduct([FromBody] CreateProductDto productDto)
    {
        Product product = _mapper.Map<Product>(productDto);

        _context.Products.Add(product);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
    }
    [HttpGet]
    public IEnumerable<Product> GetProducts() 
    {
        return _context.Products;
    }

    [HttpGet("{id}")]
    public IActionResult GetProductById(int id) 
    {
        Product product = _context.Products.FirstOrDefault(product => product.Id == id);
        
        if(product == null) return NotFound();
        return Ok(product);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateProduct(int id, UpdateProductDto productDto)
    {
        Product product = _context.Products.FirstOrDefault(product => product.Id == id);

        if (product == null) return NotFound();

        _mapper.Map(productDto, product);
        _context.SaveChanges();

        return NoContent();
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteProductById(int id)
    {
        Product product = _context.Products.FirstOrDefault(product => product.Id == id);

        if (product == null) return NotFound();

        _context.Products.Remove(product);
        _context.SaveChanges();

        return NoContent();
    }
}
