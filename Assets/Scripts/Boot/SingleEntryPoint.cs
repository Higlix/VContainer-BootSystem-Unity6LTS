using UnityEngine;
using Cysharp.Threading.Tasks;
using UnityEngine.PlayerLoop;
using System.ComponentModel;
using VContainer;
using VContainer.Unity;

public sealed class SingleEntryPoint : IStartable , ITickable
{
    
    [Inject]
    public SingleEntryPoint(LifetimeScopePrefabs lifetimeScopePrefabs, LifetimeScope rootLifetimeScope)
    {
        // container.
        Debug.Log("SEP Constructed");
        LifetimeScope.Create(lifetimeScopePrefabs.bootLiftimeScopePrefab);
    }

    public void yolo()
    {
        Debug.Log("Yolo");
    }

    void IStartable.Start()
    {
        Debug.Log("SEP");
        // Debug.Log(_bootSettings.FPS);
        // LifetimeScope.Find<RootLifetimeScope>().CreateChild<BootLifetimeScope>();
    }

    void ITickable.Tick()
    {
    }
}