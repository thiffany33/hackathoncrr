using Domain.Entities;
using Domain.Interfaces;
using Infra.Context;
using Infra.Repository.GenericRepository;
using System.Linq;

namespace Infra.Repository
{
    public class EmpresaRepository : GenericRepository<Empresa>, IEmpresaRepository
    {
        public EmpresaRepository(MainContext mainContext)
            : base(mainContext)
        {
        }

        public Empresa ObterPorCNPJ(string cnpj)
        {
            return Query().FirstOrDefault(q => q.CNPJ == cnpj);
        }
    }
}
