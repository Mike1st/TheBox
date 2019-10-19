using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForArrow : MonoBehaviour
{
    int score;
    Arrow arrow;
    const int KEY_RIGHT = 90;
    const int KEY_DOWN = 180;
    const int KEY_UP = 0;

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Hit2");
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        arrow = collision.gameObject.GetComponent<Arrow>();
        int rotation = arrow.GetRotation();
        Debug.Log("Collision Detected");
        CheckIfArrowCorrect(rotation);
    }

    private void CheckIfArrowCorrect(int rotation)
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || rotation == KEY_RIGHT)
        {
            score++;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || rotation == KEY_DOWN)
        {
            score++;   
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || rotation == KEY_UP)
        {

            score++;
        }
        Debug.Log(score);
    }
}
