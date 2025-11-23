using VContainer;
using VContainer.Unity;

// THE BRIDGE SIDE
public class HelloWorldPresenter : IStartable
{
    readonly HelloWorldService _service;
    readonly HelloWorldView _view;

    public HelloWorldPresenter(HelloWorldService service, HelloWorldView view)
    {
        _service = service;
        _view = view;
    }

    void IStartable.Start()
    {
        UnityEngine.Debug.Log("PresenterStart"); 
        _view.HelloButton.onClick.AddListener(() => _service.Hello());
    }
}
