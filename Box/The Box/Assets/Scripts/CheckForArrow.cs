using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForArrow : MonoBehaviour
{
    int score = 0;
    Arrow arrow;
    const int KEY_RIGHT = 90;
    const int KEY_DOWN = 180;
    const int KEY_UP = 0;

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        arrow = collision.gameObject.GetComponent<Arrow>();
        int rotation = arrow.GetRotation();
        CheckIfArrowCorrect(rotation);
    }

    private void CheckIfArrowCorrect(int rotation)
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (rotation == KEY_RIGHT)
            {
                score++;
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (rotation == KEY_DOWN)
            {
                score++;
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (rotation == KEY_UP)
            {
                score++;
            }
        }
        Debug.Log(score);
    }
}
