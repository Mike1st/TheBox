using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBehavior : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite[] catSprites;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
    }

    IEnumerator Start()
    {
        while (true)
        {
            int random = Random.Range(0, 2);
            Debug.Log(random);
            yield return new WaitForSeconds(5);
            spriteRenderer.sprite = catSprites[random];
        }

    }
}
