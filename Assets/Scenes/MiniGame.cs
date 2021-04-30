using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame : MonoBehaviour
{
    int speed = 100;
    bool isMovingRight = false;
    bool isMovingLeft = false;
    bool isMovingUp = false;
    bool isMovingDown = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            isMovingRight = true;
            isMovingLeft = false;
            isMovingUp = false;
            isMovingDown = false;

            while (isMovingRight == true)
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            } 
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            isMovingRight = false;
            isMovingLeft = true;
            isMovingUp = false;
            isMovingDown = false;

            while (isMovingLeft == true)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            isMovingRight = false;
            isMovingLeft = false;
            isMovingUp = true;
            isMovingDown = false;

            while (isMovingUp == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * speed);
            }  
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            isMovingRight = false;
            isMovingLeft = false;
            isMovingUp = false;
            isMovingDown = true;

            while (isMovingDown == true)
            {
                transform.Translate(Vector3.down * Time.deltaTime * speed);
            }
        }
    }
}
