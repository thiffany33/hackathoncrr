using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Validation;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Domain.Validation
{
    public class UsuarioValidacao : IUsuarioValidacao
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioValidacao(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public List<string> ValidarDeletar(Guid id)
        {
            var listaErros = new List<string>();
            if(_usuarioRepository.GetById(id) == null)
            {
                listaErros.Add("Id não encontrado");
            }
            return listaErros;
        }

        public List<string> ValidarEditar(Usuario usuario)
        {
            var listaErros = new List<string>();
            if(_usuarioRepository.GetById(usuario.Id) == null)
            {
                listaErros.Add("Id não encontrado");
            }
            return listaErros;
        }

        public List<string> ValidarCadastrar(Usuario usuario)
        {
            var listaErros = new List<string>();

            if (!ValidarNome(usuario.Nome))
            {
                listaErros.Add("Campo Nome não pode ficar em branco");
            }

            if (!ValidarRenda(usuario.Renda))
            {
                listaErros.Add("Selecione o tipo de renda");
            }

            if (!ValidarTelefone(usuario.Telefone))
            {
                listaErros.Add("Campo Telefone não pode ficar em branco");
            }
            else if (!ValidarFormatoTelefone(usuario.Telefone))
            {
                listaErros.Add("Formato de telefone incorreto");
            }

            if (!ValidarEmail(usuario.Email))
            {
                listaErros.Add("Campo Email não pode ficra em branco");
            }
            else if (!ValidarFormatoEmail(usuario.Email))
            {
                listaErros.Add("Formato de email incorreto");
            }

            return listaErros;
        }

        private static bool ValidarNome(string nome)
        {
            if (nome == null)
            {
                return false;
            }
            return true;
        }

        private static bool ValidarEmail(string email)
        {
            if (email == null)
            {
                return false;
            }
            return true;
        }

        private static bool ValidarTelefone(string telefone)
        {
            if (telefone == null)
            {
                return false;
            }
            return true;
        }

        private static bool ValidarFormatoTelefone(string telefone)
        {
            return Regex.IsMatch(telefone, @"\(\d{2}\)\s\d{8,9}");
        }

        private bool ValidarRenda(Renda renda)
        { 
            if (renda == default)
            {
                return false;
            }
            return true;
        }

        private static bool ValidarFormatoEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$");
        }
    }
}
