using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GoldenSpirit : MonoBehaviour
{
    //unity event that is triggered when the spirit is clicked
    public UnityEvent onGoldenSpiritClicked;
  
    void Update()
    {
        ////check if the mouse is clicked
        if (Input.GetMouseButtonDown(0))
        {
            //get position of mouse in world space
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //a radius of how close to the sprite counts as a click on the sprite 
            float clickArea = 1f;

            //checks if the mouse click is within the click area of the sprite
            if (Vector2.Distance(mousePos, transform.position) < clickArea)
            {
                //invokes the onGoldenSpiritClicked event
                onGoldenSpiritClicked.Invoke();

                //destroys the spirit after it is clicked
                Destroy(gameObject);
            }
        }
    }
}
