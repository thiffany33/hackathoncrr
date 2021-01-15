using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Interfaces.Validation
{
    public interface IUsuarioValidacao
    {
        public List<string> ValidarCadastrar(Usuario usuario);
        public List<string> ValidarEditar(Usuario usuario);
        public List<string> ValidarDeletar(Guid id);
    }
}
