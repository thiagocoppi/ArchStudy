using Domain.Associados;
using Domain.Base;
using Infraestrutura;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Tests.Base;

namespace Tests.Associados
{
    public class AssociadosServiceTests : BaseTestIntegration
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Dado_AssociadoMenorDeIdade_Deve_AdicionarNotificacaoDeErro()
        {
            using (var scope = StartupTest().CreateScope())
            {
                scope.ServiceProvider.GetService<ArchContext>().Database.Migrate();
                var _associadoService = scope.ServiceProvider.GetService<IAssociadoService>();
                var _notificationContext = scope.ServiceProvider.GetService<INotificationContext>();
                _associadoService.CadastrarAssociado(
                    new Associado("Thiago Coppi", 17, "07052429942", new Endereco("Rua tapajos", 74, ""))).GetAwaiter().GetResult();
                Assert.IsTrue(_notificationContext.HaveNotification());
            }
        }

        [Test]
        public void Dado_AssociadoMaiorIdade_NaoDeve_AdicionarNotificacaoDeErro()
        {
            using (var factory = new SampleDbContextFactory())
            {
                // Get a context
                using (var context = factory.CreateContext())
                {
                    using (var scope = StartupTest().CreateScope())
                    {
                        //var xpto = Substitute.For<IArchContext, ArchContext>(new DbContextOptionsBuilder<ArchContext>().UseSqlite(new SqliteConnection("DataSource=:memory:")).Options;);
                        var _associadoService = scope.ServiceProvider.GetService<IAssociadoService>();
                        var xpto = scope.ServiceProvider.GetRequiredService<IArchContext>();
                        var xpto2 = scope.ServiceProvider.GetRequiredService<ArchContext>();
                        var _notificationContext = scope.ServiceProvider.GetService<INotificationContext>();
                        _associadoService.CadastrarAssociado(
                            new Associado("Thiago Coppi", 21, "07052429942", new Endereco("Rua tapajos", 74, ""))).GetAwaiter().GetResult();
                        Assert.IsFalse(_notificationContext.HaveNotification());
                    }
                }
            }
        }
    }
}