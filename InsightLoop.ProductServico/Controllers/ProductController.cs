using AutoMapper;
using InsightLoop.Application.Services;
using InsightLoop.Domain.Entities;
using InsightLoop.Domain.Repositories;
using InsightLoop.ProductServico.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InsightLoop.ProductServico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;
        private readonly IMapper _mapper;
        public ProductController(ProductService productService,IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult Get()
        {
            var products = _productService.GetAll();
            var productsResponse = _mapper.Map<IEnumerable<Product>, IEnumerable<GetProductResponse>>(products);
            return Ok(productsResponse);
        }
        /// <summary>
        /// Cria um novo produto
        /// </summary>
        /// <param name="createProductRequest">Objeto com os campos necessários para criação de um filme</param>
        /// <returns>IActionResult</returns>
        /// <respnse code="201">Retorna o produto criado</respnse>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult Post([FromBody] CreateProductRequest createProductRequest)
        {
            var product = _mapper.Map<CreateProductRequest, Product>(createProductRequest);
            _productService.AddProduct(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var product = _productService.GetProductById(id);
            if(product == null) return NotFound();
            var productResponse = _mapper.Map<Product, GetProductResponse>(product);
            return Ok(productResponse);
        }

        // PUT api/<ProductController>/5
        /// <summary>
        /// Cria um novo produto
        /// </summary>
        /// <param name="putProduct">Objeto com os campos necessários para criação de um filme</param>
        /// <returns>IActionResult</returns>
        /// <respnse code="201">Retorna o produto criado</respnse>
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] CreateProductRequest putProduct)
        {
            var product = _productService.GetProductById(id);
            if(product == null) return NotFound();
           _mapper.Map(putProduct,product);
            _productService.UpdateProduct(product);
            return NoContent();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var product = _productService.GetProductById(id);
            if (product == null) return NotFound();
            _productService.DeleteProduct(product);
            return NoContent();
        }
    }
}
