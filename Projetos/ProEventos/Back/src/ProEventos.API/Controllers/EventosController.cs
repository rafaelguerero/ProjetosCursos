﻿using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ProEventos.Application.Contratos;
using System.Threading.Tasks;
using ProEventos.Application.Dtos;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Linq;
using ProEventos.API.Extensions;
using Microsoft.AspNetCore.Authorization;
using ProEventos.Persistence.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class EventosController : ControllerBase
    {
        private readonly IEventoService _eventoService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IAccountService _accountService;

        public EventosController(IEventoService eventoService, 
                                 IWebHostEnvironment webHostEnvironment,
                                 IAccountService accountService)
        {
            _eventoService = eventoService;
            _webHostEnvironment = webHostEnvironment;
            _accountService = accountService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]PageParams pageParams)
        {
            try
            {
                var eventos = await _eventoService.GetAllEventosAsync(User.GetUserId(), pageParams, true);
                if (eventos == null) return NotFound("Nenhum Evento encontrado");

                Response.AddPagination(eventos.CurrentPage, eventos.PageSize, eventos.TotalCount, eventos.TotalPages);

                return Ok(eventos);
            }
            catch (Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar eventos. Erro: {ex.Message}");
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var evento = await _eventoService.GetEventoByIdAsync(User.GetUserId(), id, true);
                if (evento == null) return NoContent();

                return Ok(evento);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar evento. Erro: {ex.Message}");
            }
        }        

        [HttpPost]
        public async Task<IActionResult> Post (EventoDto model)
        {
            try
            {
                var evento = await _eventoService.AddEvento(User.GetUserId(), model);
                if (evento == null) return BadRequest("Não foi possível adicionar evento.");

                return Ok(evento);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar criar evento. Erro: {ex.Message}");
            }
        }

        [HttpPost("upload-image/{eventoId}")]
        public async Task<IActionResult> UploadImage(int eventoId)
        {
            try
            {
                var evento = await _eventoService.GetEventoByIdAsync(User.GetUserId(), eventoId);
                if (evento == null) return NoContent();

                var file = Request.Form.Files[0];

                if (file.Length > 0)
                {
                    DeleteImage(evento.ImageUrl);
                    evento.ImageUrl = await SaveImage(file);
                }

                var eventoRetorno = await _eventoService.UpdateEvento(User.GetUserId(), eventoId, evento);

                return Ok(eventoRetorno);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao carregar imagem do evento. Erro: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, EventoDto model)
        {
            try
            {
                var evento = await _eventoService.UpdateEvento(User.GetUserId(), id, model);
                if (evento == null) return BadRequest("Não foi possível atualizar evento.");

                return Ok(evento);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar atualizar evento. Erro: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var evento = await _eventoService.GetEventoByIdAsync(User.GetUserId(), id, true);
                if (evento == null) return NoContent();

                if (await _eventoService.DeleteEvento(User.GetUserId(), id))
                {
                    DeleteImage(evento.ImageUrl);
                    return Ok(new { message = $"Deletado" });
                }
                else
                {
                    return BadRequest($"Não foi possível excluir o evento");
                }                 
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar excluir evento. Erro: {ex.Message}");
            }
        }

        //Método que não é endpoint
        [NonAction]
        public async Task<string> SaveImage(IFormFile imageFile)
        {
            string imageName = new string(
                Path.GetFileNameWithoutExtension(imageFile.FileName)
                .Take(10)
                .ToArray()
                ).Replace(" ", "-");

            imageName = $"{imageName}{DateTime.UtcNow.ToString("yymmssfff")}{Path.GetExtension(imageFile.FileName)}";

            var imagePath = Path.Combine(_webHostEnvironment.ContentRootPath, @"Resources/Images", imageName);

            using (var fileStream = new FileStream(imagePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(fileStream);
            }

            return imageName;
        }

        [NonAction]
        public void DeleteImage(string imageUrl)
        {
            var imagePath = Path.Combine(_webHostEnvironment.ContentRootPath, @"Resources/Images", imageUrl);
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }
        }
    }
}
