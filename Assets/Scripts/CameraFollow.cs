using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void LateUpdate()
    {
        Vector3 desired = new Vector3(target.position.x + offset.x, 0.4f, offset.z);
        transform.position = desired;
    }

}
