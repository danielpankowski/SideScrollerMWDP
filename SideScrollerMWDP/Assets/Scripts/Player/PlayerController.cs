using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Text gameOverText;

    private const float maxHealth = 100;
    private float currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void GetHit(float damage)
    {
        //1. Otrzymywanie obrazen
        //2. GameOver <= 0
    }
}
