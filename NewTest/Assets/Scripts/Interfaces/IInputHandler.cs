using System;
using UnityEngine;
public interface IInputHandler
{
    public float GetVerticalAxis();
    public float GetHorizontalAxis();
    public bool GetUseButtonDown();
    public event Action<Vector3> OnSelectButtonDown;
}