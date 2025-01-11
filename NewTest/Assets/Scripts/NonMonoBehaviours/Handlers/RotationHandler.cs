using UnityEngine;
public class RotationHandler
{
    public void Rotate(Transform transform, Vector3 direction, float rotateSpeed)
    {
        if (Vector3.Angle(transform.forward, direction) > 0)
        {
            var newDirection = Vector3.RotateTowards(transform.forward, direction, rotateSpeed, 0);
            transform.rotation = Quaternion.LookRotation(newDirection);
        }
    }
}
