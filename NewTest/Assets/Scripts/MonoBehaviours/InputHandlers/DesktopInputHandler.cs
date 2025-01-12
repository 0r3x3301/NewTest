using System;
using UnityEngine;
public class DesktopInputHandler : MonoBehaviour, IInputHandler
{
    public event Action<Vector3> OnSelectButtonDown;

    public float GetHorizontalAxis()
    {
        return Input.GetAxis("Horizontal");
    }

    public float GetVerticalAxis()
    {
        return Input.GetAxis("Vertical");
    }

    public bool GetUseButtonDown()
    {
        return Input.GetKeyDown(KeyCode.F);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnSelectButtonDown?.Invoke(Input.mousePosition);
        }

    }
}