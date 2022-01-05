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
    public class CreditCartsController : ControllerBase
    {
        private ICreditCartService _creditCartService;

        public CreditCartsController(ICreditCartService creditCartService)
        {
            _creditCartService = creditCartService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _creditCartService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _creditCartService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(CreditCart creditCart)
        {
            var result = _creditCartService.Add(creditCart);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(CreditCart creditCart)
        {
            var result = _creditCartService.Update(creditCart);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(CreditCart creditCart)
        {
            var result = _creditCartService.Delete(creditCart);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
