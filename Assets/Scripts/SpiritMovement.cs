using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpiritMovement : MonoBehaviour
{
    //animation curve component
    public AnimationCurve spiritCurve;

    //total time variable
    public float t;
    public Vector3 startPos;
    
    public float minSpeedX = 10f; //minimum horizontal movement speed
    public float maxSpeedX = 30f; //maximum horizontal movement speed

    public float speedX; //horizontal speed variable
    public float bobHeight = 1f; //how high the spirit bobbing is
    public float bobSpeed = 1f; //speed of spirit's bobbing

    

    void Start()
    {
        //assigns position of spirit
        startPos = transform.position;
        
        //assigns spirit a random speed when spawned
        speedX = Random.Range(minSpeedX, maxSpeedX);
    }

    void Update()
    {

        t += Time.deltaTime;

        float x = startPos.x + speedX * t;

        float bobLoop = t * bobSpeed % 1f;
        
        float y = startPos.y + spiritCurve.Evaluate(bobLoop) * bobHeight;

        transform.position = new Vector3(x, y, 0);

    }
}
