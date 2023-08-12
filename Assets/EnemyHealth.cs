using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float damage)
    {
        if ((health - damage) < 0)
        {
            health = 0;
            Destroy(gameObject);
        }
        else
        {
            health = health - damage;
            GetComponent<SpriteRenderer>().material.color= Color.red;
        }
        Debug.Log(health);
        
    }
}
