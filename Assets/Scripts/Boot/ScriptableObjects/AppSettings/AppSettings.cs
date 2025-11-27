using Unity;
using UnityEngine;

[CreateAssetMenu(fileName = "AppSettings", menuName = "App/Settings")]
public class AppSettings : ScriptableObject
{
    [SerializeField]
    public bool Debug = false;

    [SerializeField, Range(30, 144)]
    public int FPS = 120; 

}