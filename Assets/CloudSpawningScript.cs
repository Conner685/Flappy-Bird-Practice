using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawningScript : MonoBehaviour
{
    public GameObject cloud;
    public float cSpawnRate = 3;
    public float cTimer = 0;
    public float cHeightOffset = 10;
    public float speedOffsetMin = 30;
    public float speedOffsetMax = 45;
    // Start is called before the first frame update
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (cTimer < cSpawnRate)
        {
            cTimer += Time.deltaTime;

        }
        else
        {
            spawnCloud();
            cTimer = 0;
        }
        
    }
    void spawnCloud()
    {
        float clowestPoint = transform.position.y - cHeightOffset;
        float chighestPoint = transform.position.y + cHeightOffset;
        Instantiate(cloud, new Vector3(Random.Range(speedOffsetMin, speedOffsetMax), Random.Range(clowestPoint, chighestPoint), 1), transform.rotation);
    }
    
}
