using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject Player;

    public GameObject Bullet;
    Vector2 bulletPosition;
    public Vector2 bullOffset = new Vector2(0.0f, +0.75f);
    public bool RecentShot = false;

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.35f);
        RecentShot = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag()
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
        bulletPosition = Player.transform.position;
        bulletPosition += bullOffset;
        Instantiate(Bullet, bulletPosition, Quaternion.identity);
    }
}
