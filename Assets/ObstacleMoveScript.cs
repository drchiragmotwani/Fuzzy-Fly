using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float obstacleDeleteZone = -30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * moveSpeed;

        if (transform.position.x < obstacleDeleteZone)
        {
            Destroy(gameObject);
        }
    }
}
