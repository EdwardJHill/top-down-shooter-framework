using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSize : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.layer == 6)
        {
            collision.gameObject.GetComponent<TopDownCharacterController>().bulletSize *= 1.15f;
            Destroy(gameObject);
        }

    }

}
