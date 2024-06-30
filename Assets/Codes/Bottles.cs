using UnityEngine;
using System.Collections;

public class Bottle : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    public Transform[] spawnPoints;
    public float minSpawnDelay = 1f;
    public float maxSpawnDelay = 3f;
    private bool isSpawning = true;

    void Start()
    {
        StartCoroutine(SpawnObjects());
        StartCoroutine(UpdateSpawning());
    }

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            if (isSpawning)
            {
                for (int i = 0; i < objectsToSpawn.Length; i++)
                {
                    Transform spawnPoint = spawnPoints[i];
                    yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
                    if (isSpawning)
                    {
                        Instantiate(objectsToSpawn[i], spawnPoint.position, Quaternion.identity);
                    }
                }
            }
            else
            {
                yield return new WaitForSeconds(0.5f);
            }
        }
    }

    IEnumerator UpdateSpawning()
    {
        while (true)
        {
            float time = Time.time % 37.11f; // Cycle repeats every 37.11 seconds

            if (time >= 0f && time < 6.1f)
                isSpawning = true;
            else if (time >= 6.1f && time < 11.2f)
                isSpawning = false;
            else if (time >= 11.2f && time < 25f)
                isSpawning = true;
            else if (time >= 25f && time < 30f)
                isSpawning = true;
            else if (time >= 30f && time < 37.11f)
                isSpawning = true;
            else
                isSpawning = true; // Ensuring that it starts spawning again after 37.11 seconds

            yield return null;
        }
    }
}
