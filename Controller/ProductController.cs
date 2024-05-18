using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using kalashop.Data;
using kalashop.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace kalashop.Controller
{

    [Route("api/product")]
    [ApiController]

    public class ProductController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public ProductController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult GetAll()

        {
            var product =_context.Product.ToList()
            .Select(s => s.ToProductDto());

            return Ok(product);
        }

        [HttpGet("{id}")]

        public IActionResult GetById([FromRoute] int id)

        {
            var product = _context.Product.Find(id);


            if (product == null)

            {
                return NotFound();
            }

            return Ok(product.ToProductDto());
        }
    }

}


