using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 1.8f;
    public float heightOffset = 18;
    private float timer = 0;

    
    void Start()
    {
        spawnPipe();
    }
    
    void Update()
    {
        if (timer < spawnRate)
            timer += Time.deltaTime;
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y + (heightOffset / 3);
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0),
            transform.rotation);
    }
}