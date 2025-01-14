﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Server.Services.BrandService;

namespace Shop.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrandController : ControllerBase
{
	private readonly IBrandService _brandService;

	public BrandController(IBrandService brandService)
	{
		_brandService = brandService;
	}

	[HttpGet]
	public async Task<ActionResult<ServiceResponse<List<Brand>>>> GetBrands()
	{
		var result = await _brandService.GetBrands();
		return Ok(result);
	}
}