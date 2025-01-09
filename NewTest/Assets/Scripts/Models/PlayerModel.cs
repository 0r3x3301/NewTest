using UnityEngine;
using Zenject;
[System.Serializable]
public class PlayerModel : EntityModel, IMovable
{
    public Transform Transform { get; set; }
    public float Speed { get; set; }

    [Inject] private MovementHandler _movementHandler;
    public PlayerModel(PlayerConfig config)
    {
        Name = config.Name;
        Speed = config.Speed;
    }

    public void Move()
    {
        _movementHandler.Move(Transform, Speed);
    }
}
