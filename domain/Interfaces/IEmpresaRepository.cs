using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IEmpresaRepository
    {
        public Empresa ObterPorCNPJ(string cnpj);
    }
}
