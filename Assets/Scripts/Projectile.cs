using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    public Vector2 direction;
    public float speed = 4f;
    public void Start()
    {
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.layer == 7)
        {
            collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(5f);
        }
        if (collision.gameObject.layer == 3)
        {
            Destroy(gameObject);    
        }
        
    }
}
