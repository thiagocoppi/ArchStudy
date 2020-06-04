using Domain.Base;
using System;
using System.Threading.Tasks;

namespace Domain.Associados
{
    public interface IAssociadoService : IDomainService
    {
        Task<Associado> CadastrarAssociado(Associado associado);

        Task<Associado> ObterAssociado(Guid id);
    }
}