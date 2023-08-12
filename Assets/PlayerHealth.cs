using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health =100f;
    // Start is called before the first frame update

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
        }
        Debug.Log(health);
        
    }
}
