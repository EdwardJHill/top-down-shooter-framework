using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.layer == 6)
        {
            collision.gameObject.GetComponent<TopDownCharacterController>().playerMaxSpeed *= 1.15f;
            Destroy(gameObject);
        }

    }
}
