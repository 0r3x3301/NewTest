using UnityEngine;
using Zenject;
public class MovementHandler
{
    [Inject] private IInputHandler _inputHandler;
    public void Move(Transform transform, float speed)
    {
        var direction = new Vector3(_inputHandler.GetHorizontalInput(), transform.position.y, _inputHandler.GetVerticalInput());
        transform.position += speed * direction * Time.deltaTime;
    }
}