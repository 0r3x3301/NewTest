using UnityEngine;
[CreateAssetMenu]
public class PlayerConfig : ScriptableObject
{
    [field: SerializeField] public float Speed { get; private set; }
    [field: SerializeField] public float RotateSpeed { get; private set; }
}