﻿using AppApi.Data;
using AppApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly AppDbContext _context;
        public BookController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Book book)

        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _context.AddAsync(book);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Create", book);

        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.Books.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var data = await _context.Books.FindAsync(id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }
        public async Task<IActionResult> Delete([FromQuery] int? id)
        {
            if (id is null)
            {
                return BadRequest();
            }
            var data = await _context.Books.FindAsync(id);
            if (data is null) return NotFound();
            _context.Remove(data);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit([FromRoute] int id, [FromBody] Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var data = await _context.Books.FindAsync(id);
            if (data is null) return NotFound();
            data.Title = book.Title;
            data.Author= book.Author;
            data.Description = book.Description;

            await _context.SaveChangesAsync();

            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> Search([FromQuery] string? search)
        {
            return Ok(search == null ? await _context.Books.ToListAsync() : await _context.Books.Where(m => m.Title.Contains(search)|| m.Description.Contains(search) ) . ToListAsync() );
        }

    }
}
