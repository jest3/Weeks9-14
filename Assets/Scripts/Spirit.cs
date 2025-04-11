using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spirit : MonoBehaviour
{
    public UnityEvent onSpiritClicked;

    // Start is called before the first frame update
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
                onSpiritClicked.Invoke();
                Destroy(gameObject);
            }
        }
    }
}
