using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 10f;
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
            gameObject.transform.localScale -= new Vector3(0.5f,0.5f,0);
        }
        Debug.Log(health);
        
    }
}
