using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    private GameObject cloud;
    
    private void Start()
    {
        cloud = this.gameObject;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 600f);
            Destroy(cloud);
        }
    }
}
