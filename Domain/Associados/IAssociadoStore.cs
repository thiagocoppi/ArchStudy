using Domain.Base;
using System;
using System.Threading.Tasks;

namespace Domain.Associados
{
    public interface IAssociadoStore
    {
        Task<Associado> Save(Associado associado);

        Task<Associado> Retrieve(Guid id);
    }
}