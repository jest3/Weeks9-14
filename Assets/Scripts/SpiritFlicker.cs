using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritFlicker : MonoBehaviour
{
    //references the sprite renderer component
    public SpriteRenderer spriteRenderer;
    
    void Start()
    {
        //attaches sprite renderer component to this game object
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        //starts flicker coroutine
        StartCoroutine(SpiritFlicker());

        //coroutine that oscillates the sprite's transparency
        IEnumerator SpiritFlicker()
        {
            //setting the speed to control how fast the spirit flickers
            float speed = 2f;
            
            //setting the minimum and maximum alpha values for the sprite to flicker between
            float minAlpha = 0.3f; //minimum alpha value
            float maxAlpha = 1f; //maximum alpha value

            while (true)
            {
                //uses a ping pong lerp to oscillate the alpha value between 0 and 1
                //the 2 values being the minAlpha and maxAlpha
                float alpha = Mathf.Lerp(minAlpha, maxAlpha, Mathf.PingPong(Time.time * speed, 1f));
                
                //gets sprite colour
                Color colour = spriteRenderer.color;
                
                //updates sprite transparency
                colour.a = alpha;
                spriteRenderer.color = colour;

                //wait for the next frame before repeating
                yield return null;
            }
        }
    }
}
