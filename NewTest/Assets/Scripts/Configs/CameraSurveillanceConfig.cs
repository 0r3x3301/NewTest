using UnityEngine;
[CreateAssetMenu]
public class CameraSurveillanceConfig : ScriptableObject
{
    [field: Header("Position offset")]
    [field: SerializeField, Range(-10, 10)] public float PositionOffsetX { get; private set; }
    [field: SerializeField, Range(0, 20)] public float PositionOffsetY { get; private set; }
    [field: SerializeField, Range(-25, 0)] public float PositionOffsetZ { get; private set; }

    [field: Header("Rotation offset")]
    [field: SerializeField, Range(0, 1)] public float RotationOffsetX { get; private set; }
    [field: SerializeField, Range(-1, 1)] public float RotationOffsetY { get; private set; }
    [field: SerializeField, Range(-1, 1)] public float RotationOffsetZ { get; private set; }
}