using System;
using System.Collections.Generic;
// using bloggr.Models;
// using bloggr.Services;
using System.Security.Claims;
using CLibrary.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CLibrary.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class LibrariesController : ControllerBase
  {
    private readonly BooksService _bs;
    private readonly LibrariesService _ls;
    public LibrariesController(LibrariesService ls, BooksService bs)
    {
      _ls = ls;
      _bs = bs;

    }

    [HttpGet]
    public ActionResult<IEnumerable<Library>> Get()
    {
      try
      {
        return Ok(_ls.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}