using UnityEngine;
using Cysharp.Threading.Tasks;
using VContainer;
using VContainer.Unity;

public sealed class SingleEntryPoint : IStartable
{
    readonly AppBootstrapper bootstrapper;

    readonly LifetimeScope rootLifetimeScope;

    readonly LifetimeScopePrefabs lifetimeScopePrefabs;

    [Inject]
    public SingleEntryPoint(
            AppBootstrapper bootstrapper,
            LifetimeScope rootLifetimeScope,
            LifetimeScopePrefabs lifetimeScopePrefabs
        )
    {
        this.lifetimeScopePrefabs = lifetimeScopePrefabs;
        this.rootLifetimeScope = rootLifetimeScope;
        this.bootstrapper = bootstrapper;
    }

    void IStartable.Start()
    {
        RunBootSequence().Forget();
    }

    private async UniTaskVoid RunBootSequence()
    {
        LifetimeScope bootLifetimeScope = rootLifetimeScope.CreateChildFromPrefab
            (lifetimeScopePrefabs.bootLiftimeScopePrefab.GetComponent<BootLifetimeScope>());

        Debug.Log("BootLifetimeScope created");

        await bootstrapper.BootAsync();

        bootLifetimeScope.Dispose();
        Debug.Log("BootLifetimeScope disposed");
    }
}
