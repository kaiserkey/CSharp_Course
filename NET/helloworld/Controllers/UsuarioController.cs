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
    public async Task<IActionResult> Post([FromBody] modelType model)
    {
      try
      {
        
    
        // TODO Remove
        await Task.Yield();
    
        return Created("", null);
      }
      catch (Exception)
      {
        return BadRequest();
      }
    }

}