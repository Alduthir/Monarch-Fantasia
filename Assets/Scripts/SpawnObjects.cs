using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public List<GameObject> flowers;
    public List<GameObject> obstacles;
    public float minSpawnBound = -15;
    public float maxSpawnBound = 15;
    public float spawnYPosition = 8f;
    public float flowerMinSpawnTime = .5f;
    public float flowerMaxSpawnTime = 3f;
    public float obstacleMinSpawnTime = 1f;
    public float obstacleMaxSpawnTime = 2f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(SpawnFlower), flowerMinSpawnTime);
        Invoke(nameof(SpawnObstacle), obstacleMinSpawnTime);
    }

    void SpawnFlower()
    {
        float xPos = Random.Range(minSpawnBound, maxSpawnBound);
        int flowerIndex = Random.Range(0, flowers.Count);
        Instantiate(
            flowers[flowerIndex], 
            new Vector3(xPos,spawnYPosition),
            flowers[flowerIndex].transform.rotation
            );
        
        Invoke(nameof(SpawnFlower), Random.Range(flowerMinSpawnTime, flowerMaxSpawnTime));
    }

    void SpawnObstacle()
    {
        float xPos = Random.Range(minSpawnBound, maxSpawnBound);
        int obstacleIndex = Random.Range(0, obstacles.Count);
        Instantiate(
            obstacles[obstacleIndex], 
            new Vector3(xPos,spawnYPosition),
            obstacles[obstacleIndex].transform.rotation
        );
        Invoke(nameof(SpawnObstacle), Random.Range(obstacleMinSpawnTime,obstacleMaxSpawnTime));
    }
}
