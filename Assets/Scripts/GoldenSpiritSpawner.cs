using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoldenSpiritSpawner : MonoBehaviour
{
    public GameObject goldenSpiritPrefab;
    public SpiritScore scoreManager;
    public LanternSprite lanternSpriteManager;

    //spawns the spirits at random positions
    public Transform[] spawnPoints;

    //sets how often the spirits spawn
    public float goldenSpawnInterval = 8f;

    public float minPosX = -12;
    public float maxPosX = 12;
    public float minPosY = -1;
    public float maxPosY = 4;

    void Start()
    {
        StartCoroutine(SpawnGoldenSpirit());
    }

        IEnumerator SpawnGoldenSpirit()
        {
            while (true)
            {

            yield return new WaitForSeconds(goldenSpawnInterval);

            Vector2 randomPosition = new Vector2
                    (Random.Range(minPosX, maxPosX),
                     Random.Range(minPosY, maxPosY));

                //instantiates spirit
                GameObject newGoldenSpirit = Instantiate(goldenSpiritPrefab, randomPosition, Quaternion.identity);

                GoldenSpirit goldenSpiritScript = newGoldenSpirit.GetComponent<GoldenSpirit>();

                if (goldenSpiritScript != null && scoreManager != null && lanternSpriteManager != null)
                {
                    goldenSpiritScript.onGoldenSpiritClicked.AddListener(scoreManager.goldenSpiritScore);
                    goldenSpiritScript.onGoldenSpiritClicked.AddListener(lanternSpriteManager.ChangeLantern);
                }

                //yield return new WaitForSeconds(goldenSpawnInterval);

                Destroy(newGoldenSpirit, 10f);
            }

        }
    }