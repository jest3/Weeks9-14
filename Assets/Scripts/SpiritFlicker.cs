using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritFlicker : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //starts flicker coroutine
        StartCoroutine(SpiritFlicker());

        IEnumerator SpiritFlicker()
        {
            //setting the speed to control how fast the spirit flickers
            float speed = 2f;
            //setting the minimum and maximum alpha values for the sprite to flicker between
            float minAlpha = 0.3f;
            float maxAlpha = 1f;

            while (true)
            {
                //ping pong lerp to oscillate the alpha value between 0 and 1
                //the 2 values being the minAlpha and maxAlpha
                float alpha = Mathf.Lerp(minAlpha, maxAlpha, Mathf.PingPong(Time.time * speed, 1f));
                Color colour = spriteRenderer.color;
                
                //updates sprite transparency
                colour.a = alpha;
                spriteRenderer.color = colour;

                yield return null;
            }
        }
    }
}
