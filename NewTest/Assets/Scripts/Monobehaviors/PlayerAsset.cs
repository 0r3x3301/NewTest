using UnityEngine;
using Zenject;

public class PlayerAsset : MonoBehaviour
{
    [Inject] private PlayerModel _playerModel;
    [Inject] private IInputHandler _inputHandler;

    private void Awake()
    {
        _playerModel.Transform = GetComponent<Transform>();
    }

    private void Update()
    {
        if (_inputHandler.GetVerticalInput() != 0 || _inputHandler.GetHorizontalInput() != 0)
        {
            _playerModel.Move();
        }
    }
}
