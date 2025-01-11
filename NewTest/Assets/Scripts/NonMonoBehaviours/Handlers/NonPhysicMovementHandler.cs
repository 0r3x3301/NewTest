using UnityEngine;
public class NonPhysicMovementHandler
{
    private CharacterController _characterController;
    public NonPhysicMovementHandler(CharacterController characterController)
    {
        _characterController = characterController;
    }
    public void Move(float speed, Vector3 direction)
    {
        direction = direction * speed;
        _characterController.Move(direction);
    }
}
