using DefaultNamespace;
using VContainer;
using VContainer.Unity;

public class NewMonoBehaviourScript : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterInstance(builder);
        builder.Register<FooFactory>(Lifetime.Singleton);

        builder.RegisterFactory<Foo>(resolver =>
        {
            var factory = resolver.Resolve<FooFactory>();
            return factory.Create;
        }, Lifetime.Singleton);
        
        builder.Register<Bootstrapper>(Lifetime.Singleton)
               .AsImplementedInterfaces()
               .AsSelf();
    }
}
