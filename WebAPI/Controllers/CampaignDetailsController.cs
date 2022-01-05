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
    public class CampaignDetailsController : ControllerBase
    {
        private ICampaignDetailService _campaignDetailService;

        public CampaignDetailsController(ICampaignDetailService campaignDetailService)
        {
            _campaignDetailService = campaignDetailService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _campaignDetailService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _campaignDetailService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(CampaignDetail campaignDetail)
        {
            var result = _campaignDetailService.Add(campaignDetail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update(CampaignDetail campaignDetail)
        {
            var result = _campaignDetailService.Update(campaignDetail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(CampaignDetail campaignDetail)
        {
            var result = _campaignDetailService.Delete(campaignDetail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
