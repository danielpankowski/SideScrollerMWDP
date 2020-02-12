using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Text gameOverText;
    [SerializeField]
    private PlayerMovement playerMovement;

    private const float maxHealth = 100;
    private float currentHealth;
    private bool gameOver = false;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void GetHit(float damage, Vector3 direction, float throwBackForce)
    {
        Debug.LogError("GetHit");
        currentHealth -= damage;
        playerMovement.ThrowBack(direction, throwBackForce);
        if (currentHealth <= 0)
        {
            gameOver = true;
        }
        gameOverText.gameObject.SetActive(gameOver);
    }
}
