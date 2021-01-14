using Domain.Entities;
using Domain.Interfaces;
using Infra.Context;
using Infra.Repository.GenericRepository;

namespace Infra.Repository
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(MainContext mainContext)
            : base(mainContext)
        {
        }
    }
}
