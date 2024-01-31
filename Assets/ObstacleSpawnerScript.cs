using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Collections;
using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
{

    public GameObject obstacle;
    public float spawnRate = 3;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnObstacle();
            timer = 0;
        }
    }

    void SpawnObstacle()
    {
        float highestPoint = transform.position.y + heightOffset;
        float lowestPoint = transform.position.y - heightOffset;

        Instantiate(obstacle, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z), transform.rotation);
    }

    public void ChangeSpawnRate(int playerScore)
    {
        spawnRate -= (float) playerScore/((float) playerScore + 300);

        if (spawnRate < 1)
        {
            spawnRate = 1;
        }
    }
}
