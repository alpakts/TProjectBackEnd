using Business.Abstract;
using Core.Entity.Concrete;
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
    public class UserClaimController : ControllerBase
    {
        IUserClaimService _service;

        public UserClaimController(IUserClaimService service)
        {
            _service = service;
        }
        [HttpPost("add")]
        public async Task<IActionResult> Add(UserOperationClaim claim)
        {
            await Task.CompletedTask;
            var result = _service.Add(claim);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPost("delete")]
        public async Task<IActionResult> Delete(UserOperationClaim claim)
        {
            await Task.CompletedTask;
            var result = _service.Delete(claim);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPost("update")]
        public async Task<IActionResult> Update(UserOperationClaim claim)
        {
            await Task.CompletedTask;

            var result = _service.Update(claim);
            if (result.Success)
            {
                await Task.CompletedTask;
                return Ok(result);
                
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            await Task.CompletedTask;
            var result = _service.GetAlll();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("getbyclaim")]
        public async Task<IActionResult> GetByClaim(int claim)
        {
            await Task.CompletedTask;
            var result = _service.GetByClaim(claim);
            if (result.Success)
            {

                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
