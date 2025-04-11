using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GoldenSpirit : MonoBehaviour
{
    public UnityEvent onGoldenSpiritClicked;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if mouse is clicked
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float clickArea = 1f;

            if (Vector2.Distance(mousePos, transform.position) < clickArea)
            {
                onGoldenSpiritClicked.Invoke();
                Destroy(gameObject);
            }
        }
    }
}
