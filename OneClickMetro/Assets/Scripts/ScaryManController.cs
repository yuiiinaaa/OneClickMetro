using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaryManController : MonoBehaviour
{
    public Sprite scarySprite1;
    public Sprite scarySprite2;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void StartSpriteChange()
    {
        StartCoroutine(SpriteChangeCoroutine());
    }

    IEnumerator SpriteChangeCoroutine()
    {
        // Change to the second sprite after 0.5 seconds (adjust the duration as needed)
        yield return new WaitForSeconds(0.5f);

        // Change the sprite to the second scary sprite
        if (spriteRenderer != null && scarySprite2 != null)
        {
            spriteRenderer.sprite = scarySprite2;
        }
    }
}
