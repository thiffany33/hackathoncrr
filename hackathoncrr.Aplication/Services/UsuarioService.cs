using Aplication.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Validation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aplication.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IUsuarioValidacao _usuarioValidacao;

        public UsuarioService(IUsuarioRepository usuarioRepository, IUsuarioValidacao usuarioValidacao)
        {
            _usuarioRepository = usuarioRepository;
            _usuarioValidacao = usuarioValidacao;
        }

        public List<string> Cadastrar(Usuario usuario)
        {
            var erros = _usuarioValidacao.ValidarCadastrar(usuario);
            if (erros.Count() == 0)
            {
                _usuarioRepository.Create(usuario);
            }
            return erros;
        }

        public List<string> Editar(Usuario usuario)
        {
            var erros = _usuarioValidacao.ValidarEditar(usuario);
            if(erros.Count() == 0)
            {
                _usuarioRepository.Update(usuario);
            }
            return erros;
        }

        public List<string> Deletar(Guid id)
        {
            var erros = _usuarioValidacao.ValidarDeletar(id);
            if (!erros.Any())
            {
                _usuarioRepository.Delete(id);
            }
            return erros;
        }

        public IEnumerable<Usuario> ListarTodos()
        {
            return _usuarioRepository.GetAll();
        }

        public Usuario PesquisarPorId(Guid id)
        {
            return _usuarioRepository.ObterPorID(id);
        }
    }
}
