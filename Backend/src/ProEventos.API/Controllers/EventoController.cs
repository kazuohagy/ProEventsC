using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {

        }

        [HttpGet]
        public string Get()
        {
            return "Evento Get";
        }

        [HttpPost]
        public string Post()
        {
            return "Evento Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Evento Put {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Evento Delete {id}";
        }
    }
}
