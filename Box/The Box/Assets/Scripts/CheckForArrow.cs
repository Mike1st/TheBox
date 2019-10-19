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
    int rotation = 0;
    public static CheckForArrow instance;

    private void Awake()
    {
        instance = this;
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.anyKeyDown)
        {
            CheckIfArrowCorrect();
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        arrow = collision.gameObject.GetComponent<Arrow>();
        rotation = arrow.GetRotation();
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    arrow = collision.gameObject.GetComponent<Arrow>();
    //    int rotation = arrow.GetRotation();
    //    CheckIfArrowCorrect(rotation);
    //}

    private void CheckIfArrowCorrect()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && rotation == KEY_RIGHT)
        {
            Debug.Log("Right Key Detected");
            CatBehavior.instance.SetCatLives(-1);
            score++;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && rotation == KEY_DOWN)
        {
            Debug.Log("Down Key Detected");
            CatBehavior.instance.SetCatLives(-1);
            score++;
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow) && rotation == KEY_UP)
        {
            Debug.Log("Up Key Detected");
            CatBehavior.instance.SetCatLives(-1);
            score++;
        }
        else
        {
            Debug.Log("BAd");
        }
    }
}
