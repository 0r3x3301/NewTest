using System;
using UnityEngine;

public class DesktopInputHandler : MonoBehaviour, IInputHandler
{
    public event Action OnUseButtonDown;
    public event Action<Vector3> OnSelectObjectButtonDown;

    public float GetHorizontalInput()
    {
        return Input.GetAxis("Horizontal");
    }

    public float GetVerticalInput()
    {
        return Input.GetAxis("Vertical");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) OnUseButtonDown?.Invoke();
        if (Input.GetMouseButtonDown(0)) OnSelectObjectButtonDown?.Invoke(Input.mousePosition);
    }
}