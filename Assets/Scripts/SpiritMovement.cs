using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpiritMovement : MonoBehaviour
{
    //adds animation curve component to give a graph shape to the vertical bobbing movement
    public AnimationCurve spiritCurve;

    //total time
    public float t;
    
    //start position of the spirit
    public Vector3 startPos;
    
    public float minSpeedX = 10f; //minimum horizontal movement speed
    public float maxSpeedX = 30f; //maximum horizontal movement speed

    public float speedX; //horizontal speed variable that gets randomized using the min and max speeds
    public float bobHeight = 1f; //how high the spirit bobbing is
    public float bobSpeed = 1f; //how fast the vertical bobbing loops

    void Start()
    {
        //spirits starting position at spawn
        startPos = transform.position;
        
        //assigns spirit a random speed using the min and max horizontal speeds as a range when spawned
        speedX = Random.Range(minSpeedX, maxSpeedX);
    }

    void Update()
    {
        //increments the timer with each frame
        t += Time.deltaTime;

        //horizontal speed gets added to the starting position to move the spirit
        float x = startPos.x + speedX * t;

        //bobbing gets looped by setting it back to 0 (1/1)
        float bobLoop = t * bobSpeed % 1f;
        
        //updates the bobbing movement using the animation curve
        float y = startPos.y + spiritCurve.Evaluate(bobLoop) * bobHeight;

        //updates the spirits position using the horizontal movement and the vertical bobbing
        transform.position = new Vector3(x, y, 0);

    }
}
