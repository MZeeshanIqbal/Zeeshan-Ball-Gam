using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private float spawnLimitX = 10.0f;
    private float spawnPosY = 9.0f;
    private float startDelay = 2.0f;
    public float repeatDelay = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnRandomBall", startDelay, repeatDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnRandomBall()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnLimitX, spawnLimitX), spawnPosY, transform.position.z);
        
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        Instantiate(ballPrefabs[ballIndex], spawnPos,ballPrefabs[0].transform.rotation) ;
    }
}
