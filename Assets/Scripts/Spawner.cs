using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spiritPrefab;
    public SpiritScore scoreManager;
    
    //spawns the spirits at random positions
    public Transform[] spawnPoints;

    //sets how often the spirits spawn
    public float spawnInterval = 8f;

    public float minPosX = -10f;
    public float maxPosX = 10f;
    public float minPosY = 4f;
    public float maxPosY = -1f;

    void Start()
    {
        StartCoroutine(SpawnSpirits());
    }

    IEnumerator SpawnSpirits()
    {
        while(true)
        {
            Vector2 randomPosition = new Vector2
                (Random.Range(minPosX, maxPosX),
                 Random.Range(minPosY, maxPosY));

            //instantiates spirit
            GameObject newSpirit = Instantiate(spiritPrefab, randomPosition, Quaternion.identity);

            Spirit spiritScript = newSpirit.GetComponent<Spirit>();

            if (spiritScript != null && scoreManager != null)
            {
                spiritScript.onSpiritClicked.AddListener(scoreManager.addToScore);
            }
            
            yield return new WaitForSeconds(spawnInterval);

            Destroy(newSpirit, 10f);
        }


    }
}
