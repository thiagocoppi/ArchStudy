using Domain.Base;
using System;
using System.Threading.Tasks;

namespace Domain.Associados
{
    public sealed class AssociadoService : IAssociadoService
    {
        private readonly INotificationContext _notificationContext;
        private readonly IAssociadoStore _associadoStore;

        public AssociadoService(INotificationContext notificationContext, IAssociadoStore associadoStore)
        {
            _notificationContext = notificationContext;
            _associadoStore = associadoStore;
        }

        public async Task<Associado> CadastrarAssociado(Associado associado)
        {
            //Validação genérica para exemplificação de adição de uma notificação de domínio, não externalizando uma exception.
            if (associado.Idade < 18)
            {
                _notificationContext.AddNotification(new Notification("Associado menor de idade", "Não é possível cadastrar um associado menor de idade"));
                return null;
            }

            var associadoCadastrado = await _associadoStore.Save(associado);

            return associadoCadastrado;
        }

        public async Task<Associado> ObterAssociado(Guid id)
        {
            var associadoEncontrado = await _associadoStore.Retrieve(id);

            return associadoEncontrado;
        }
    }
}