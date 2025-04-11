using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpiritMovement : MonoBehaviour
{
    public AnimationCurve spiritCurve;

    //sets range of animation curve
    //[Range(0, 1)]

    //total time variable
    public float t;
    public Vector3 startPos;
    
    public float speedX = 2f; //horizontal movement speed
    public float bobHeight = 1f; //how high the spirit bobbing is
    public float bobSpeed = 1f; //speed of spirit's bobbing

    //sets position 1 and position 2 that the spirit will lerp between
    //public Transform pos1;
    //public Transform pos2;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {

        //moves possition 1 and position 2 for lerping to the left so that the spirit can move across the screen
        //pos1.position += Vector3.left * speedX * Time.deltaTime;
        //pos2.position += Vector3.left * speedX * Time.deltaTime;
        
        t += Time.deltaTime * bobSpeed;

        //if t is greater than 1 (0 to 1 is the range) the t will be reset to 0 so that the animation is looped
        //if (t > 1)
        //{
        //    t = 0;
        //}

        float x = startPos.x * speedX * t;

        float bobLoop = t * bobSpeed % 1f;
        
        float y = startPos.y + spiritCurve.Evaluate(t * bobSpeed) * bobHeight;

        transform.position = new Vector3(x, y, 0);

        //updates the spirits position between the pos1 and pos2 points and makes it according to the animation curve
        //transform.position = Vector2.Lerp(pos1.position, pos2.position, spiritCurve.Evaluate(t));
    }
}
