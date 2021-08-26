﻿using EntityCrudApp001.Models;
using EntityCrudApp001.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityCrudApp001.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService _bookService;
        public BooksController(BooksService booksService)
        {
            _bookService = booksService;
        }

        [HttpPost]
        public IActionResult CreateBook([FromBody]Book book)
        {
            _bookService.CreateBook(book);
            return Ok();
        }
    }
}
