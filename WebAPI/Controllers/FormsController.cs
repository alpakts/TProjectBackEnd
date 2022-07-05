using Business.Abstract;
using Core.Utilities.Results;
using Entities.DTOs;
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
    public class FormsController : ControllerBase
    {
        FormService _service;

        public FormsController(FormService service)
        {
            _service = service;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _service.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(TechnicForm form)
        {
            var result = _service.Add(form);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyformcode")]
        public IActionResult GetByFormCode(int formCode)
        {
            var result = _service.GetByFormCode(formCode);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbystatusid")]
        public IActionResult GetByStatusId(int statusid)
        {
            var result = _service.GetAllByStatusIId(statusid);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallbyuserid")]
        public IActionResult GetByUserId(int userId)
        {
            var result = _service.GetAllByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        
         public IActionResult Delete(TechnicForm form){
        var result=_service.Delete(form);
        if (result.Success)
        {
            return Ok(result);
        }else{
            return BadRequest(result);
        }
        }
        [HttpPost("update")]
        public IActionResult Update(TechnicForm form){
        var result=_service.Update(form);
        if (result.Success)
        {
            return Ok(result);
        }else{
            return BadRequest(result);
        }
        }
    }
   
}
