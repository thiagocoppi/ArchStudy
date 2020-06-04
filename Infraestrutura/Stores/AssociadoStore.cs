using Domain.Associados;
using System;
using System.Threading.Tasks;

namespace Infraestrutura.Stores
{
    public sealed class AssociadoStore : IAssociadoStore
    {
        private readonly IArchContext _context;

        public AssociadoStore(IArchContext context)
        {
            _context = context;
        }

        public async Task<Associado> Retrieve(Guid id)
        {
            return await _context.Associados.FindAsync(id);
        }

        public async Task<Associado> Save(Associado associado)
        {
            var associadoAdicionado = await _context.Associados.AddAsync(associado);
            await _context.SaveChangesAsync();

            return associadoAdicionado.Entity;
        }
    }
}