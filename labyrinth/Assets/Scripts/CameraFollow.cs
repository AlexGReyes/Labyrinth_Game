using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    public float smootSpeed = 0.125f;
    //public 

    private void LateUpdate() {
        Vector3 offset = new Vector3(0.0f, 7.53f, -9.16f);
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smootSpeed);
        transform.position = smoothedPosition;
    }
}
