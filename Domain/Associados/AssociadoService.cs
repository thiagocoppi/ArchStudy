using Domain.Base;
using System.Threading.Tasks;

namespace Domain.Associados
{
    public sealed class AssociadoService : IDomainService, IAssociadoService
    {
        private readonly INotificationContext _notificationContext;

        public AssociadoService(INotificationContext notificationContext)
        {
            _notificationContext = notificationContext;
        }

        public Task<bool> CadastrarAssociado(Associado associado)
        {
            //Validação genérica para exemplificação de adição de uma notificação de domínio, não externalizando uma exception.
            if (associado.Idade < 18)
            {
                _notificationContext.AddNotification(new Notification("Erro notification", "Não foi possível cadastrar o associado"));
            }

            return Task.FromResult(true);
        }
    }
}