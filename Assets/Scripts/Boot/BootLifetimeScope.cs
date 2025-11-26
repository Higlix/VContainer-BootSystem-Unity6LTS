using System;
using VContainer;
using VContainer.Unity;
using UnityEngine;

public class BootLifetimeScope : LifetimeScope
{
    [SerializeField]
    BootSettings bootSettings;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterInstance(bootSettings);
    }
}
