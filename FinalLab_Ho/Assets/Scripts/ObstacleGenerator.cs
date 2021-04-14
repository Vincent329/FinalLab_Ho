using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject obstacles;
    [SerializeField] private int lifespan;
    int timer = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if (timer >= lifespan)
        {
            timer = 0;
            GameObject obstacle = Instantiate(obstacles, new Vector2(obstacles.transform.position.x + 10.0f, obstacles.transform.position.y + Random.Range(-2, 2)), obstacles.transform.rotation);
            Destroy(obstacle, 8.0f);
        }
    }
}
