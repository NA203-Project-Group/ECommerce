using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorySubsController : ControllerBase
    {
        private ICategorySubService _categorySubService;

        public CategorySubsController(ICategorySubService categorySubService)
        {
            _categorySubService = categorySubService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _categorySubService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _categorySubService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(CategorySub categorySub)
        {
            var result = _categorySubService.Add(categorySub);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(CategorySub categorySub)
        {
            var result = _categorySubService.Update(categorySub);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(CategorySub categorySub)
        {
            var result = _categorySubService.Delete(categorySub);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
