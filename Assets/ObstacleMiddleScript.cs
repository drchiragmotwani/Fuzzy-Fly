using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public ObstacleSpawnerScript spawner;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.Find("LogicManager").GetComponent<LogicScript>();
        spawner = GameObject.Find("ObstacleSpawner").GetComponent<ObstacleSpawnerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.AddScore(1);
            spawner.ChangeSpawnRate(logic.playerScore);
        }
    }
}
