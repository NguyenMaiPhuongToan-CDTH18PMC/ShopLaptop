using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopLapTop.Api.Service;
using ShopLapTop.Shared.Request;

namespace ShopLapTop.Api.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
           _productService = productService;
        }
        //Quan Ly Kho
        [HttpGet("Kho")]
        public async Task<IActionResult> GetKhos()
        {
            try
            {
                return Ok(await _productService.GetKhos());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        [HttpPost("Kho")]
        public async Task<IActionResult> AddKho(KhoRequest request)
        {
            try
            {
                var result = await _productService.AddKho(request);
                if (result.IsSuccess)
                    return Ok(result);
                return BadRequest(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        //Quan Ly Nha Cung Cap
        [HttpGet("NhaCungCap")]
        public async Task<IActionResult> GetNhaCCs()
        {
            try
            {
                return Ok(await _productService.GetNhaCCs());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }
        [HttpPost("NhaCungCap")]
        public async Task<IActionResult> AddNhaCC(NhaCCRequest request)
        {
            try
            {
                var result =await _productService.AddNhaCC(request);
                if (result.IsSuccess)
                    return Ok(result);
                return BadRequest(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        //QUan Ly Khuyen Mai
        [HttpGet("KhuyenMai")]
        public async Task<IActionResult> GetKhuyenmais()
        {
            try
            {
                return Ok(await _productService.GetKhuyenMais());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }
        [HttpPost("KhuyenMai")]
        public async Task<IActionResult> AddKhuyenMai(KhuyenMaiRequest request)
        {
            try
            {
                var result = await _productService.AddKM(request);
                if (result.IsSuccess)
                    return Ok(result);
                return BadRequest(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        //Quan Ly Chi Nhanh
        [HttpGet("ChiNhanh")]
        public async Task<IActionResult> GetChiNhanhs()
        {
            try
            {
                return Ok(await _productService.GetChiNhanh());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }
        [HttpPost("ChiNhanh")]
        public async Task<IActionResult> AddChiNhanh(ChiNhanhRequest request)
        {
            try
            {
                var result = await _productService.AddChiNhanh(request);
                if (result.IsSuccess)
                    return Ok(result);
                return BadRequest(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }
    }
}
