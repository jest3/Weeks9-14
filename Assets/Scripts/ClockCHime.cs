using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockCHime : MonoBehaviour
{
    public KitClock clock;

    public void Start()
    {
        clock.OnTheHour.AddListener(Chime);
    }

    public void Chime(int hour)
    {
        Debug.Log("Chiming" + hour + " o'clock !");
    }

    public void ChimeWithoutArguments()
    {
        Debug.Log("Chiming!");
    }
}
