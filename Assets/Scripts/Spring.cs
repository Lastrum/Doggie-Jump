using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 1000f);
        }
    }
}
