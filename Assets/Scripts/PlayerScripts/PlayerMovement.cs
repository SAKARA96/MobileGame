using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Player;
    public float shipBoundary = 12;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDrag()
    {
        Vector2 touchPosition = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
        // Boundary top and bottom
        //if (touchPosition.y + shipBoundary > Camera.main.orthographicSize)
        //{
        //    touchPosition.y = Camera.main.orthographicSize + shipBoundary;
        //}

        //if (touchPosition.y - shipBoundary < -Camera.main.orthographicSize)
        //{
        //    touchPosition.y = -Camera.main.orthographicSize + shipBoundary;
        //}
        Vector2 playerPosition = Camera.main.ScreenToWorldPoint(touchPosition);
        Player.transform.position = playerPosition;

    }


}
