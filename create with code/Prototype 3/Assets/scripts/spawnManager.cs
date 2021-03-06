﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerControler playerControlerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControlerScript = GameObject.Find("Player").GetComponent<PlayerControler>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpwanObstacle()
    {
        if (playerControlerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
