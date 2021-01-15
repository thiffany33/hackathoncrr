using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Aplication.Interfaces
{
    public interface IUsuarioService
    {
        public List<string> Deletar(Guid id);
        public List<string> Editar(Usuario usuario);
        public List<string> Cadastrar(Usuario usuario);
    }
}
