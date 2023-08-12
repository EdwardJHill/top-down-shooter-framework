using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    [SerializeField]
    public GameObject enemyPrefab;
    public float spawnrate = 3.5f;
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
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5),Random.Range(-6f,6f),0), Quaternion.identity);
        StartCoroutine(spawn(interval,enemy));
    }
}
