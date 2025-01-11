using UnityEngine;
public class DesktopInputHandler : IInputHandler
{
    public float GetHorizontalAxis()
    {
        return Input.GetAxis("Horizontal");
    }

    public float GetVerticalAxis()
    {
        return Input.GetAxis("Vertical");
    }
}