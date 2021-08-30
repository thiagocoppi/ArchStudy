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

        [Test]
        public void Dado_AssociadoMenorDeIdade_Deve_AdicionarNotificacaoDeErro()
        {
            using var scope = StartupTest().CreateScope();
            var _associadoService = scope.ServiceProvider.GetService<IAssociadoService>();
            var _notificationContext = scope.ServiceProvider.GetService<INotificationContext>();
            _associadoService.CadastrarAssociado(
                new Associado("Thiago Coppi", 17, "07052429942", new Endereco("Rua tapajos", 74, ""))).GetAwaiter().GetResult();
            Assert.IsTrue(_notificationContext.HaveNotification());
        }

        [Test]
        public void Dado_AssociadoMaiorIdade_NaoDeve_AdicionarNotificacaoDeErro()
        {
            using var scope = StartupTest().CreateScope();
            using var factory = new SampleDbContextFactory();
            using var context = factory.CreateContext();
            context.Database.OpenConnection();
            context.Database.Migrate();
            var _database = scope.ServiceProvider.GetRequiredService<ArchContext>();
            _database.Database.MigrateAsync().GetAwaiter().GetResult();
            var _associadoService = scope.ServiceProvider.GetService<IAssociadoService>();
            var _notificationContext = scope.ServiceProvider.GetService<INotificationContext>();
            _associadoService.CadastrarAssociado(
                new Associado("Thiago Coppi", 21, "07052429942", new Endereco("Rua tapajos", 74, ""))).GetAwaiter().GetResult();
            Assert.IsFalse(_notificationContext.HaveNotification());
            context.Database.CloseConnection();
        }
    }
}