using Autofac;
using Domain.Associados;
using Infraestrutura.Stores;

namespace Infraestrutura
{
    public sealed class InfraestruturaModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<ArchContext>().As<IArchContext>().SingleInstance();
            builder.RegisterType<AssociadoStore>().As<IAssociadoStore>().InstancePerLifetimeScope();
        }
    }
}