using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    void LateUpdate()
    {
        if(target.position.x - transform.position.x > 3f)
        {
          transform.position = new Vector3(target.position.x - 3f, 0.4f, -5f);
        }
        else if(target.position.x - transform.position.x < -5f)
        {
          transform.position = new Vector3(target.position.x + 5f, 0.4f, -5f);
        }
    }

}
