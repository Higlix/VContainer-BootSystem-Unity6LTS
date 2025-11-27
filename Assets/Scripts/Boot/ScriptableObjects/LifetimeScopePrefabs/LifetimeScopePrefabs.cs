using Unity;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "LifetimeScopePrefabs", menuName = "LifetimeScopePrefabs/Prefabs")]
public class LifetimeScopePrefabs : ScriptableObject
{
    [SerializeField]
    public GameObject bootLiftimeScopePrefab;
}