﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CourierManageApi.Models;
using CourierManageApi.Attributes;
using Microsoft.AspNetCore.Cors;

namespace CourierManageApi.Controllers
{

    [EnableCors("Policy1")]
    [AuthAttribute("", "Comapnys")]
    [Route("api/[controller]")]
    [ApiController]
    public class ComapnysController : ControllerBase
    {
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Company>>> GetComapnys()
        //{
        //    CourierApiContext _context = new CourierApiContext();
        //    return await _context.Companys.ToListAsync();
        //}

        //// GET: api/Comapnys/5
        ////[EnableCors("Policy1")]
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Company>> GetCompany(int id)
        //{
        //    CourierApiContext _context = new CourierApiContext();
        //    var company = await _context.Companys.FindAsync(id);

        //    if (company == null)
        //    {
        //        return NotFound();
        //    }

        //    return company;
        //}

        //// PUT: api/Comapnys/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCompany(int id, Company company)
        //{
        //    CourierApiContext _context = new CourierApiContext();
        //    if (id != company.CompanyId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(company).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CompanyExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Comapnys
        //[HttpPost]
        //public async Task<ActionResult<Company>> PostCompany(Company company)
        //{
        //    CourierApiContext _context = new CourierApiContext();
        //    _context.Companys.Add(company);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetCompany", new { id = company.CompanyId }, company);
        //}

        //// DELETE: api/Comapnys/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteCompany(int id)
        //{
        //    CourierApiContext _context = new CourierApiContext();
        //    var company = await _context.Companys.FindAsync(id);
        //    if (company == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Companys.Remove(company);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool CompanyExists(int id)
        //{
        //    CourierApiContext _context = new CourierApiContext();
        //    return _context.Companys.Any(e => e.CompanyId == id);
        //}

    }
}

