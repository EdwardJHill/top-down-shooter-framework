using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    [SerializeField]
    public GameObject enemyPrefab;
    public float spawnrate = 3f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawn(spawnrate,enemyPrefab));
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private IEnumerator spawn(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(spawnrate);
       //target = GameObject.FindWithTag("Player").transform;
        //if(target.transform.x <) system to spawn enemy away from player
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-10.5f, 8.5f),Random.Range(-4.5f,2.5f),0), Quaternion.identity);
        StartCoroutine(spawn(interval,enemy));
    }
}
