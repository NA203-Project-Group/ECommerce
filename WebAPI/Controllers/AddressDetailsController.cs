using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressDetailsController : ControllerBase
    {
        private IAddressDetailService _addressDetailService;

        public AddressDetailsController(IAddressDetailService addressDetailService)
        {
            _addressDetailService = addressDetailService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _addressDetailService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _addressDetailService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(AddressDetail addressDetail)
        {
            var result = _addressDetailService.Add(addressDetail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(AddressDetail addressDetail)
        {
            var result = _addressDetailService.Update(addressDetail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(AddressDetail addressDetail)
        {
            var result = _addressDetailService.Delete(addressDetail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
