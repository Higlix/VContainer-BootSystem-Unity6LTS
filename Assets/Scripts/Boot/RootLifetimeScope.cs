using System;
using VContainer;
using VContainer.Unity;
using UnityEngine;

public class RootLifetimeScope : LifetimeScope
{
    [SerializeField]
    LifetimeScopePrefabs lifetimeScopePrefabs;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterInstance(lifetimeScopePrefabs);

        builder.RegisterEntryPoint<SingleEntryPoint>();
    }
}
