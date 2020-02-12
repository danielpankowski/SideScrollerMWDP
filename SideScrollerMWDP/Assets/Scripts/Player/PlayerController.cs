using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Text gameOverText;
    [SerializeField]
    private Rigidbody rigidbody;

    private const float maxHealth = 100;
    private float currentHealth;
    private bool gameOver = false;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void GetHit(float damage)
    {
        currentHealth -= damage;
        rigidbody.velocity = new Vector3(rigidbody.velocity.x, 200 * Time.deltaTime);
        if (currentHealth <= 0)
        {
            gameOver = true;
        }
        gameOverText.gameObject.SetActive(gameOver);
    }
}
