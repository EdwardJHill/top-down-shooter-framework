using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    public Vector2 direction;
    public float speed = 5f;
    public void Start()
    {
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collide");
        Destroy(gameObject);
    }
}
