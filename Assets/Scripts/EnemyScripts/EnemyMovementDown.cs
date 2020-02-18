using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementDown : MonoBehaviour
{
    public float velX = 0f;
    public float velY = -5f;
    Rigidbody2D enemyBody;

    // Start is called before the first frame update
    void Start()
    {
        enemyBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyBody.velocity = new Vector2(velX, velY);
        
    }
}
