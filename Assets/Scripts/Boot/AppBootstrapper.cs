using Cysharp.Threading.Tasks;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class AppBootstrapper
{
    readonly IAnalyticsService analyticsService;
    readonly IAdsService adsService;
    readonly IPaymentService paymentService;

    [Inject]
    public AppBootstrapper(
        IAnalyticsService analyticsService,
        IAdsService adsService,
        IPaymentService paymentService)
        
    {
        this.analyticsService = analyticsService;
        this.adsService = adsService;
        this.paymentService = paymentService;
    }

    public async UniTask BootAsync()
    {
        Debug.Log("Boot Sequence Started...");

        await analyticsService.InitializeAsync();
        await adsService.InitializeAsync();
        await paymentService.InitializeAsync();

        Debug.Log("Boot Sequence Completed!");
    }
}

