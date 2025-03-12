using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PointerEvents : MonoBehaviour

{ public SpriteRenderer pirate;
    public Sprite pizza;

    public void MouseHover()
    {
        //trying to change the sprite in the sprite renderer component
        pirate = GetComponent<SpriteRenderer>();
        pirate.sprite = pizza;
    }

    public void MouseExit()
    {
        //sprite change
    }

    public void MouseClick()
    {
        //spawn prefab
    }
}

