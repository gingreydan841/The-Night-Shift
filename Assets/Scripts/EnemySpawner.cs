using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject honeyBarrelPrefab;
    public GameObject door;
    public GameObject floorExit;

    public Transform appleSpawnPoint;
    public Transform honeySpawnPoint;

    public int totalEnemies = 10;
    public float minSpawnTime = 1f;
    public float maxSpawnTime = 2f;

    private int enemiesSpawned = 0;

    void Start()
    {
        door.SetActive(false);

        if (floorExit != null)
        {
            floorExit.SetActive(false);
        }

        Invoke("SpawnEnemy", Random.Range(minSpawnTime, maxSpawnTime));
    }

    void SpawnEnemy()
    {
        if (enemiesSpawned >= totalEnemies)
        {
            return;
        }

        int enemyChoice = Random.Range(0, 2);

        if (enemyChoice == 0)
        {
            Instantiate(applePrefab, appleSpawnPoint.position, Quaternion.identity);
        }
        else
        {
            Instantiate(honeyBarrelPrefab, honeySpawnPoint.position, Quaternion.identity);
        }

        enemiesSpawned++;

        if (enemiesSpawned < totalEnemies)
        {
            Invoke("SpawnEnemy", Random.Range(minSpawnTime, maxSpawnTime));
        }
        else
        {
            door.SetActive(true);

            if (floorExit != null)
            {
                floorExit.SetActive(true);
            }
        }
    }

}
