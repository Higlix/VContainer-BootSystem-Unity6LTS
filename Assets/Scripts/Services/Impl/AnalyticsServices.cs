using Cysharp.Threading.Tasks;
using UnityEngine;
using System;

public class AndroidAnalyticsService : IAnalyticsService
{
    public async UniTask InitializeAsync()
    {
        Debug.Log("Initializing Android Analytics...");
        await UniTask.Delay(TimeSpan.FromSeconds(0.5f));
        Debug.Log("Android Analytics Initialized.");
    }
}

public class IOSAnalyticsService : IAnalyticsService
{
    public async UniTask InitializeAsync()
    {
        Debug.Log("Initializing iOS Analytics...");
        await UniTask.Delay(TimeSpan.FromSeconds(0.5f));
        Debug.Log("iOS Analytics Initialized.");
    }
}

