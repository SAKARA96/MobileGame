using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    int health = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger!");
        health--;
        
    }

    private void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
