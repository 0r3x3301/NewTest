using UnityEngine;
[CreateAssetMenu]
public class PlayerConfig : ScriptableObject
{
    [field: SerializeField] public string Name { get; private set; }
    [field: SerializeField] public float Speed { get; private set; }
    [field: SerializeField] public float Health { get;private set; }
    [field: SerializeField] public Vector3 StartPosition { get; private set; }

}
