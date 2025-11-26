using UnityEngine;
using VContainer;
using VContainer.Unity;

public class HelloWorldLifetimeScope : LifetimeScope
{
    [SerializeField]
    private HelloWorldView _view;

    protected override void Configure(IContainerBuilder builder)
    {
      builder.Register<HelloWorldService>(Lifetime.Singleton);
      builder.RegisterEntryPoint<HelloWorldPresenter>();
      builder.RegisterComponent(_view);
    }
}
