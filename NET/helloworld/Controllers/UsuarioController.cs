using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace helloworld.Controllers;

public class UsuarioController : Controller
{

    public IActionResult Index(){
        return View();
    }

    [HttpPost]
    public IActionResult Post([FromBody] modelType model)
    {
      try
      {
        
        return Created("", null);
      }
      catch (Exception)
      {
        return BadRequest();
      }
    }

}