using VContainer;
using VContainer.Unity;
using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class ServiceA 
{
    SingleEntryPoint _sep;
    public ServiceA()
    {
        Debug.Log("ServiceA Constructed");
        _sep = LifetimeScope.Find<RootLifetimeScope>().Container.Resolve<SingleEntryPoint>();
        Debug.Log("ServicesA");
        SceneManager.LoadScene(1);
        _sep.yolo();
    }

} 

public sealed class Controller : IStartable , ITickable
{
    void IStartable.Start()
    {
        ServiceA serviceA = LifetimeScope.Find<BootLifetimeScope>().Container.Resolve<ServiceA>();
        LifetimeScope.Find<RootLifetimeScope>().Container.Resolve<SingleEntryPoint>().yolo();
    }
    void ITickable.Tick()
    {
        Debug.Log("CONTROLLER TICK");
    }
}