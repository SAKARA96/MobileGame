using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float velX = 0f;
    public float velY = 5f;
    Rigidbody2D bulletBody;

    // Start is called before the first frame update
    void Start()
    {
        bulletBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bulletBody.velocity = new Vector2(velX, velY);
        Destroy(gameObject, 5f);
    }
}
