using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject Enemy;

    public GameObject Bullet;
    Vector2 bulletPosition;
    public Vector2 bullOffset = new Vector2(0.0f, -0.75f);
    public bool RecentShot = false;

    IEnumerator wait()
    {
        yield return new WaitForSeconds(2f);
        RecentShot = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!RecentShot)
        {
            RecentShot = true;
            FireBullet();
            StartCoroutine(wait());
        }
    }

    void FireBullet()
    {
        bulletPosition = Enemy.transform.position;
        bulletPosition += bullOffset;
        Instantiate(Bullet, bulletPosition, Quaternion.identity);
    }
}
