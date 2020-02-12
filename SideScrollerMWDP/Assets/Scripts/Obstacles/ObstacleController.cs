using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    float damage = 50;
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<PlayerController>().GetHit(damage);
    }
}
