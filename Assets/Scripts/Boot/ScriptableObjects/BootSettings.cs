using Unity;
using UnityEngine;

[CreateAssetMenu(fileName = "BootSettings", menuName = "Boot/Settings")]
public class BootSettings : ScriptableObject
{
    [SerializeField]
    public bool Debug = false;

    [SerializeField, Range(30, 144)]
    public int FPS = 120; 

}