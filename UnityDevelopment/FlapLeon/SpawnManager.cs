using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Transform spawnPosition;
    public float minSpawnDelay = 1.0f;
    public float maxSpawnDelay = 2.0f;
    public float minSpawnHeight = 0.0f;
    public float maxSpawnHeight = 3.0f;

    private bool canSpawn = false;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (canSpawn)
        {
            StartCoroutine(SpawnObstacle());
            canSpawn = false;
        }
    }

    IEnumerator SpawnObstacle()
    {
        float delay = Random.Range(minSpawnDelay, maxSpawnDelay);
        float height = Random.Range(minSpawnHeight, maxSpawnHeight);
        Vector3 spawnPos = spawnPosition.position + new Vector3(0, height, 0);

        Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);

        yield return new WaitForSeconds(delay);

        canSpawn = true;
    }

    private void StartGame()
    {
        canSpawn = true;
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }
}
