using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform lookAt;

    private Vector3 offset = new Vector3(0, 0, -10f);
    private Vector3 cameraPosition;

    private void Awake()
    {
        transform.position = lookAt.position + offset;
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(lookAt.transform.position.x, lookAt.transform.position.y, transform.position.z);
    }
}
