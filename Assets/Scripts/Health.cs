using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealth = 100f;
    public float health;

    private void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log(gameObject.name + " умер");
        Destroy(gameObject);
    }
}