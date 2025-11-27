using Cysharp.Threading.Tasks;
using UnityEngine;
using System;

public class MockAnalyticsService : IAnalyticsService
{
    public async UniTask InitializeAsync()
    {
        Debug.Log("Initializing Mock Analytics...");
        await UniTask.Delay(TimeSpan.FromSeconds(0.1f));
    }
}

public class MockAdsService : IAdsService
{
    public async UniTask InitializeAsync()
    {
        Debug.Log("Initializing Mock Ads...");
        await UniTask.Delay(TimeSpan.FromSeconds(0.1f));
    }
}

public class MockPaymentService : IPaymentService
{
    public async UniTask InitializeAsync()
    {
        Debug.Log("Initializing Mock Payment...");
        await UniTask.Delay(TimeSpan.FromSeconds(0.1f));
    }
}

