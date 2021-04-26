using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.01f;
    public Vector3 offset;

    void LateUpdate()
    {
      Vector3 desired = new Vector3(target.position.x + offset.x, 0.4f, offset.z);
      Vector3 position = new Vector3(target.position.x, 0.4f, offset.z);
      Vector3 smoothed = Vector3.Lerp(position, desired, smoothSpeed);
      transform.position = smoothed;
    }

}
