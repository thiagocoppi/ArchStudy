using Autofac;
using Domain.Associados;

namespace Domain
{
    public sealed class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<AssociadoService>().As<IAssociadoService>().InstancePerLifetimeScope();
        }
    }
}