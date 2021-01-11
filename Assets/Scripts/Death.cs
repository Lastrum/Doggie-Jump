using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    private GameObject death;
    
    private void Start()
    {
        death = this.gameObject;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            Debug.Log("You Died..");
        }
    }
}
