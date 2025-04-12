using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //references the spirit prefab
    public GameObject spiritPrefab;

    //references the score manager
    public SpiritScore scoreManager;

    //sets how often the spirits spawn
    public float spawnInterval = 8f;

    //minimum and maximum x and y parameters for the spirit to spawn within
    public float minPosX = -12;
    public float maxPosX = 12;
    public float minPosY = -1;
    public float maxPosY = 5;

    void Start()
    {
        //starts spirit spawning coroutine
        StartCoroutine(SpawnSpirits());
    }

    //coroutine for spirit spawning
    IEnumerator SpawnSpirits()
    {
        //loops spirit spawning
        while(true)
        {
            //spawns spirit at random position within the x and y parameters set above
            Vector2 randomPosition = new Vector2
                (Random.Range(minPosX, maxPosX),
                 Random.Range(minPosY, maxPosY));

            //instantiates spirit prefab
            GameObject newSpirit = Instantiate(spiritPrefab, randomPosition, Quaternion.identity);

            //gets spirit script from the new spirit spawned
            Spirit spiritScript = newSpirit.GetComponent<Spirit>();

            //if there is both the spirit and score script, when the spirit is clicked, add to the score ("spirits caught")
            if (spiritScript != null && scoreManager != null)
            {
                spiritScript.onSpiritClicked.AddListener(scoreManager.addToScore);
            }
            
            //wait for the spawn interval before spawning a new spirit
            yield return new WaitForSeconds(spawnInterval);

            //destory the spirit after 10 seconds if not clicked
            Destroy(newSpirit, 10f);
        }


    }
}
