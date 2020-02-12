using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField]
    private float throwBackForce = 10;
    [SerializeField]
    private float damage = 50;


    private void OnCollisionEnter(Collision collision)
    {
        Vector3 directon = (collision.transform.position - transform.position).normalized;
        collision.gameObject.GetComponent<PlayerController>().GetHit(damage, directon, throwBackForce);
    }
}
