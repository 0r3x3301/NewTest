using UnityEngine;
public class CameraSurveillanceHandler : MonoBehaviour
{
    [SerializeField] private CameraSurveillanceConfig _config;
    [SerializeField] private Transform _transform;

    private Transform _target;

    public void SetTarget(Transform target)
    {
        _target = target;
    }

    private void OnValidate()
    {
        _transform = GetComponent<Transform>();
        if (_config == null) Debug.LogWarning("Select the config!");
    }

    private void Start()
    {
        RotateToTarget();
    }

    private void RotateToTarget()
    {
        _transform.LookAt(_target);
        var newRotation = new Quaternion(_target.rotation.x + _config.RotationOffsetX, _target.rotation.y + _config.RotationOffsetY, _target.rotation.z + _config.RotationOffsetZ, _target.rotation.w);
        _transform.rotation = newRotation;
    }

    private void Update()
    {
        Folow();
    }

    private void Folow()
    {
        var newPosition = new Vector3(_target.position.x + _config.PositionOffsetX, _target.position.y + _config.PositionOffsetY, _target.position.z + _config.PositionOffsetZ);
        _transform.position = newPosition;
    }
}