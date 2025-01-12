using UnityEngine;
using Zenject;
[RequireComponent(typeof(CharacterController))]
public class PlayerAsset : MonoBehaviour
{
    [Inject] private IInputHandler _inputHandler;
    [Inject] private PlayerConfig _config;

    [SerializeField] private Transform _transform;
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private ItemTaker _itemTaker;

    private NonPhysicMovementHandler _movementHandler;
    private RotationHandler _rotationHandler = new();
    private Inventory _inventory = new();

    private void OnValidate()
    {
        if (_characterController == null) _characterController = GetComponent<CharacterController>();
        if (_transform == null) _transform = GetComponent<Transform>();
        if (_itemTaker == null) _itemTaker = GetComponent<ItemTaker>();
    }

    private void Awake()
    {
        _movementHandler = new(_characterController);
        _itemTaker.Init(_inventory);
    }

    private void Update()
    {
        var direction = new Vector3(_inputHandler.GetHorizontalAxis(), 0, _inputHandler.GetVerticalAxis());
        _movementHandler.Move(_config.Speed * Time.deltaTime, direction);
        _rotationHandler.Rotate(_transform, direction, _config.RotateSpeed * Time.deltaTime);
    }
}
