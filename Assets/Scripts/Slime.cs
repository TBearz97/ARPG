using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour, IEnemy
{
    public float currHealth, power, toughness;
    public float maxHealth;

    void Start ()
    {
        currHealth = maxHealth;
    }

    public void PreformAttack()
    {
    }

    public void TakeDamage(int amount)
    {
        currHealth -= amount;
        Debug.Log(currHealth);
        if (currHealth <= 0) {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
