using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritMovement : MonoBehaviour
{
    public AnimationCurve spiritCurve;

    //sets range of animation curve
    [Range(0, 1)]

    //total time variable
    public float t;
    float speedX = 0.05f;

    //position 1 of the spirit and position 2 of the spirit
    public Transform pos1;
    public Transform pos2;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 posX = transform.position;
        posX.x += speedX;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(posX);

        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speedX = speedX * -1;
        }

        transform.position = posX;
        
        t += Time.deltaTime;

        //loops the animation
        if (t > 1)
        {
            t = 0;
        }

        transform.position = Vector2.Lerp(pos1.position, pos2.position, spiritCurve.Evaluate(t));
    }
}
