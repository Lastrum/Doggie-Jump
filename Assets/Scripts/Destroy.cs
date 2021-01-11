using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    public GameObject springPrefab;
    public GameObject cloudPrefab;
    public GameObject deathPrefab;
    private GameObject myPlat;

    private int height = 14;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.tag.Equals("Death"))
        {
            int random = Random.Range(1, 10);
            switch (random)
            {
                default:
                    myPlat = (GameObject) Instantiate(platformPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (height + Random.Range(-0.2f, 1f))), Quaternion.identity);
                    break;
                case 12:
                    myPlat = (GameObject) Instantiate(springPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (height + Random.Range(0.2f, 1f))), Quaternion.identity);
                    break;
                case 2:
                    myPlat = (GameObject) Instantiate(cloudPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (height + Random.Range(0.2f, 1f))), Quaternion.identity);
                    break;
                case 3:
                    myPlat = (GameObject) Instantiate(deathPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (height + Random.Range(0.2f, 1f))), Quaternion.identity);
                    myPlat = (GameObject) Instantiate(platformPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (height + Random.Range(0.2f, 1f))), Quaternion.identity);
                    
                    break;

            }
        }
        Destroy(other.gameObject);
    }

}