﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    public GameObject springPrefab;
    private GameObject myPlat;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (Random.Range(1, 6) > 1) {
            myPlat = (GameObject) Instantiate(platformPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14 + Random.Range(0.5f, 1f))), Quaternion.identity);
        }
        else {
            myPlat = (GameObject) Instantiate(springPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14 + Random.Range(0.5f, 1f))), Quaternion.identity);    
        }
        Destroy(other.gameObject);
    }
}