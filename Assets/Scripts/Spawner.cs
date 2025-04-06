using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    public GameObject spiritPrefab;
    //sets how often the spirits spawn
    public float spawnInterval = 2f;

    //assigning a listener for clicked spirit event
    public UnityEvent onSpiritClicked;

    public SpriteRenderer spriteRenderer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
