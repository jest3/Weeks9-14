using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoldenSpiritSpawner : MonoBehaviour
{
    //references golden spirit prefab
    public GameObject goldenSpiritPrefab;
    
    //references score manager
    public SpiritScore scoreManager;
    
    //references the lantern sprite manager
    public LanternSprite lanternSpriteManager;

    //sets how often the spirits spawn
    public float goldenSpawnInterval = 8f;

    //minimum and maximum x and y parameters for the spirit to spawn within
    public float minPosX = -12;
    public float maxPosX = 12;
    public float minPosY = -1;
    public float maxPosY = 4;

    void Start()
    {
        //starts golden spirit spawning coroutine
        StartCoroutine(SpawnGoldenSpirit());
    }

        //coroutine for golden spirit spawning
        IEnumerator SpawnGoldenSpirit()
        {
            //loops spirit spawning
            while (true)
            {

            //wait for the spawn interval before spawning a new golden spirit
            yield return new WaitForSeconds(goldenSpawnInterval);

            //spawns spirit at random position within the x and y parameters set above
            Vector2 randomPosition = new Vector2
                    (Random.Range(minPosX, maxPosX),
                     Random.Range(minPosY, maxPosY));

                //instantiates golden spirit
                GameObject newGoldenSpirit = Instantiate(goldenSpiritPrefab, randomPosition, Quaternion.identity);

                //gets golden spirit script from the new spirit spawned
                GoldenSpirit goldenSpiritScript = newGoldenSpirit.GetComponent<GoldenSpirit>();

                //if there is both the spirit, score, and lantern manager script, when the spirit is clicked, add to the score and change the lantern to the golden lantern
                if (goldenSpiritScript != null && scoreManager != null && lanternSpriteManager != null)
                {
                    goldenSpiritScript.onGoldenSpiritClicked.AddListener(scoreManager.goldenSpiritScore);
                    goldenSpiritScript.onGoldenSpiritClicked.AddListener(lanternSpriteManager.ChangeLantern);
                }

                //destory the golden spirit after 10 seconds if it is not clicked
                Destroy(newGoldenSpirit, 10f);
            }

        }
    }