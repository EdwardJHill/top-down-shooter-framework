using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EnemyHealth : MonoBehaviour
{
    public float health = 10f;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.FindWithTag("text");
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
            text.GetComponent<timer>().addToScore(100);
            if( GameObject.FindWithTag("Spawner").GetComponent<Spawning>().spawnrate >= 0.7f)
            {
            GameObject.FindWithTag("Spawner").GetComponent<Spawning>().spawnrate /= 1.04f; 
            }
            Destroy(gameObject);
        }
        else
        {
            health = health - damage;
            gameObject.transform.localScale -= new Vector3(0.5f,0.5f,0);
        }
       
        
    }
}
