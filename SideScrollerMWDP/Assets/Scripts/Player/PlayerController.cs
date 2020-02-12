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

    public void GetHit(float damage)
    {
        currentHealth -= damage;
        playerMovement.ThrowBack();
        if (currentHealth <= 0)
        {
            gameOver = true;
        }
        gameOverText.gameObject.SetActive(gameOver);
    }
}
