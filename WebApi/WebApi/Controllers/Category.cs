using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private MyDbContext _context;

        public CategoryController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var listCategory = _context.Category.ToList();
            return Ok(listCategory);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var loai = _context.Category.SingleOrDefault(data => data.IdCategory == id);

            if (loai == null)
                return NotFound();
            else
                return Ok(loai);
        }

        [HttpPost]
        public IActionResult Add(CategoryModel model)
        {
            try
            {
                var loai = new Category
                {
                    NameCategory = model.NameCategory
                };
                _context.Add(loai);
                _context.SaveChanges();

                return Ok(loai);
            }
            catch
            {
                return BadRequest();
            }

        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, CategoryModel model)
        {
            var loai = _context.Category.SingleOrDefault(data => data.IdCategory == id);

            if (loai == null)
                return NotFound();
            else
            {
                loai.NameCategory = model.NameCategory;
                _context.SaveChanges();
                return Ok(loai);
            }


        }
    }
}
