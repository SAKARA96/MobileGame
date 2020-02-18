using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public int health = 3;
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
