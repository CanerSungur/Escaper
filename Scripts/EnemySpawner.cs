using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    /*
        # Array halindeki SpawnPointlerden bir adet secip orada dusman spawn edecegiz.
    */

    public GameObject enemyPrefab;
    private Transform spawnPoint;
    public float timeBetweenSpawn = 0.3f;
    public float countdown = 2f;

    void Update()
    {
        if (countdown <= 0f)
        {
            //Spawn Noktasini belirle
            spawnPoint = SpawnPoints.spawnPoints[Random.Range(0, 21)];

            //Enemy Spawn et
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            countdown = timeBetweenSpawn;
            return;
        }

        countdown -= Time.deltaTime;
        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);
    }
}
