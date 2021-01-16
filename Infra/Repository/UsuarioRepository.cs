using Domain.Entities;
using Domain.Interfaces;
using Infra.Context;
using Infra.Repository.GenericRepository;
using System;
using System.Linq;

namespace Infra.Repository
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(MainContext mainContext)
            : base(mainContext)
        {
        }

        public Usuario ObterPorID(Guid id)
        {
            return Query().FirstOrDefault(q => q.Id == id);
        }
    }
}
