using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kalashop.Data;
using Microsoft.AspNetCore.Mvc;

namespace kalashop.Controller
{

    [Route("api/category")]
    [ApiController]

    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public CategoryController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult GetAll()

        {
            var category =_context.Category.ToList()
            .Select(s => s.ToCategoryDto());

            return Ok(category);
        }

        [HttpGet("{id}")]

        public IActionResult GetById([FromRoute] int id)

        {
            var category = _context.Category.Find(id);


            if (category == null)

            {
                return NotFound();
            }

            return Ok(category.ToCategoryDto());
        }
    }

}