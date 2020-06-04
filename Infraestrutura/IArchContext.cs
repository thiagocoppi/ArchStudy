using Domain.Associados;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Infraestrutura
{
    public interface IArchContext
    {
        public DbSet<Associado> Associados { get; set; }

        Task SaveChangesAsync();
    }
}