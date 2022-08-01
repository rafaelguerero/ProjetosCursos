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
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento{
                    EventoId = 1,
                    Tema = "Angular 11 e dot net 5",
                    Local = "Ribeirão Preto",
                    Lote = "Primeiro lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImageUrl = "foto.png"
                },
                new Evento{
                    EventoId = 2,
                    Tema = "Angular 11 e dot net 5",
                    Local = "Ribeirão Preto",
                    Lote = "Segundo lote",
                    QtdPessoas = 200,
                    DataEvento = DateTime.Now.AddDays(3).ToString(),
                    ImageUrl = "foto.png"
                }
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
            return _evento.Where(evento => evento.EventoId == id);

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
