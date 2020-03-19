using System.Threading.Tasks;

namespace Domain.Associados
{
    public sealed class AssociadoService : IDomainService, IAssociadoService
    {
        public Task<bool> CadastrarAssociado(Associado associado)
        {
            return Task.FromResult(true);
        }
    }
}