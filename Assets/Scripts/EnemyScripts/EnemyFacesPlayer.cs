using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFacesPlayer : MonoBehaviour
{
    Transform player;
    public float rotSpeed = 30f;

    // Update is called once per frame
    void Update()
    {
        if(player == null)
        {
            GameObject go = GameObject.Find("PlayerShip");

            if (go != null)
            {
                player = go.transform;
            }
        }

        if (player == null)
        {
            return;
        }

        Vector3 dir = player.position - transform.position;
        //get direction of vector to turn
        dir.Normalize();

        float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg + 90; 

        //get the final rotation position
        Quaternion desRot = Quaternion.Euler(0, 0, zAngle);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, desRot, rotSpeed * Time.deltaTime);




    }

    
}
