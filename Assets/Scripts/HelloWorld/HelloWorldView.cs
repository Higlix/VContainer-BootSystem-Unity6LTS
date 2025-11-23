using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

// UNITY SIDE
public class HelloWorldView : MonoBehaviour
{
    [SerializeField]
    Button _button;

    public Button HelloButton => _button;

    void Start()
    {
        Debug.Log("ViewStart");
    }
}
