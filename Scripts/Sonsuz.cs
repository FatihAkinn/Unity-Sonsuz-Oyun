using UnityEngine;

public class VerticalCameraController : MonoBehaviour
{
    public Transform target; 
    public float distance = 10.0f; 
    public float height = 5.0f;  float damping = 2.0f; 

    private Vector3 initialOffset;

    void Start()
    {
        initialOffset = transform.position - target.position;
    }

    void LateUpdate()
    {
        
        transform.LookAt(target);

        
        Vector3 targetPosition = target.position + initialOffset;
        targetPosition.y += height;
        targetPosition.z -= distance;

        
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * damping);
    }
}
