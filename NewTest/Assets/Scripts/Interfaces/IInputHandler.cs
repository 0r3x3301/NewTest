using System;
using UnityEngine;

public interface IInputHandler
{
    public float GetHorizontalInput();
    public float GetVerticalInput();
    public event Action OnUseButtonDown;
    public event Action<Vector3> OnSelectObjectButtonDown;
}