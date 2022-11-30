using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
            {
                new Evento()
                {
                Id = 1,
                Tema = "Angular e .NET Core",
                Local = "São Paulo",
                Lote = "1º Lote",
                QtdPessoas = 250,
                ImagemURL = "foto.png",
                Telefone = "11 99999-9999",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                        new Evento()
                {
                Id = 2,
                Tema = "Angular e novidades",
                Local = "Paraiba",
                Lote = "2º Lote",
                QtdPessoas = 350,
                ImagemURL = "foto.png",
                Telefone = "11 99999-9999",
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
                },
            };
        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.Id == id);
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
