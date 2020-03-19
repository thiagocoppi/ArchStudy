using System.Threading.Tasks;

namespace Domain.Associados
{
    public interface IAssociadoService : IDomainService
    {
        Task<bool> CadastrarAssociado(Associado associado);
    }
}