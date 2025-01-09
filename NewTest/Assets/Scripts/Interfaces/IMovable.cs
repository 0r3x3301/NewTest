using UnityEngine;

public interface IMovable
{
    public Transform Transform { get; set; }
    public float Speed { get; set; }
    public void Move();
}