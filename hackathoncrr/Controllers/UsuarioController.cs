using Aplication.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace API.Controllers
{
    [ApiController]
    [Route("Usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        [Route("Cadastrar")]
        public ActionResult Cadastrar(Usuario usuario)
        {
            var erros = _usuarioService.Cadastrar(usuario);
            if (erros.Count() > 0)
            {
                return BadRequest(erros);
            }
            return Ok("Cadastrado com Sucesso");
        }

        [HttpPut]
        [Route("Editar")]
        public ActionResult Editar(Usuario usuario)
        {
            var erros = _usuarioService.Editar(usuario);
            if (erros.Count() > 0)
            {
                return BadRequest(erros);
            }
            return Ok("Atualizado com Sucesso");
        }

        [HttpDelete]
        [Route("Deletar")]
        public ActionResult Deletar(Guid id)
        {
            var erros = _usuarioService.Deletar(id);
            if (erros.Any())
            {
                return BadRequest(erros);
            }
            return Ok("Deletado com Sucesso");
        }
    }
}
