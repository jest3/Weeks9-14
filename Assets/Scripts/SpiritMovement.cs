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
    
    //x movement speed
    float speedX = 2f;

    //sets position 1 and position 2 that the spirit will lerp between
    public Transform pos1;
    public Transform pos2;

    void Start()
    {
    
    }

    void Update()
    {

        //moves possition 1 and position 2 for lerping to the left so that the spirit can move across the screen
        pos1.position += Vector3.left * speedX * Time.deltaTime;
        pos2.position += Vector3.left * speedX * Time.deltaTime;
        
        t += Time.deltaTime;

        //if t is greater than 1 (0 to 1 is the range) the t will be reset to 0 so that the animation is looped
        if (t > 1)
        {
            t = 0;
        }

        //updates the spirits position between the pos1 and pos2 points and makes it according to the animation curve
        transform.position = Vector2.Lerp(pos1.position, pos2.position, spiritCurve.Evaluate(t));
    }
}
