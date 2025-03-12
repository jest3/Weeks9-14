using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventDemo : MonoBehaviour
{
    public RectTransform banana;

    public UnityEvent OnTimeIsUp;
    public float timerLength = 2;
    public float t;

    private void Update()
    {
        t += Time.deltaTime;
        if (t > timerLength)
        {
            OnTimeIsUp.Invoke();
            t = 0;
        }
        //if(t < timerLength)
        //{
        //    t += Time.deltaTime;
        //}
        //else
        //{
        //    OnTimeIsUp.Invoke();
        //}
    }
    public void MouseJustEntered()
    {
        Debug.Log("Mouse just entered me.");

        banana.localScale = Vector3.one * 1.2f;
    }

    public void MouseJustLeft()
    {
        Debug.Log("Mouse just left me.");
        
        banana.localScale = Vector3.one;
    }
}
