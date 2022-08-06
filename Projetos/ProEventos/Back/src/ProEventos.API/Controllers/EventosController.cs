using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _Context;

        public EventosController(DataContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _Context.Eventos;

        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _Context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Value Post";
        }

        [HttpPut]
        public string Put(int id)
        {
            return $"Value Put ID {id}";
        }

        [HttpDelete]
        public string Delete(int id)
        {
            return $"Value Delete ID {id}";
        }
    }
}
