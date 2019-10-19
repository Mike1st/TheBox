using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    int rotation;
    Rigidbody2D rigidBody2D;

    private void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        rigidBody2D.AddForce(new Vector2(-300,0));
        ChangeArrowDirection();
    }


    public void ChangeArrowDirection()
    {
        int random = Random.Range(0, 3);
        if (random == 0)
        {
            rotation = 90;
            Debug.Log("-90");
        }
        if (random == 1)
        {
            rotation = 180;
            Debug.Log("180");
        }
        if (random == 2)
        {
            rotation = 0;
            Debug.Log("270");
        }

        rigidBody2D.rotation = rotation;
    }
}
