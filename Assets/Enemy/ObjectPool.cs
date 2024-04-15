using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField][Range(0.1f, 15f)] float spawnTimer = 2f;
    [SerializeField][Range(0, 50)] int poolSize = 5;
    [SerializeField] GameObject[] enemyPrefab;

    GameObject[] pool;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    void Awake()
    {
        PopulatePool();        
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            EnableObjectInPool();
            if (spawnTimer > 0)
            {
                yield return new WaitForSeconds(spawnTimer);
            }
        }
    }
     void EnableObjectInPool()
    {
        for (int j = 0; j < pool.Length; j++)
        {
            if (pool[j].activeInHierarchy == false)
            {
                pool[j].SetActive(true);
                return; //resets the loop early instead of waiting for enemy object to reach end of path to spawn another.
            }            
        }
    }

    void PopulatePool()
    {
        pool = new GameObject[poolSize]; //Initializes pool array with size.
        int randomindex = Random.Range(0, enemyPrefab.Length);

        for (int i = 0; i < pool.Length; i++)
        {            
            pool[i] = Instantiate(enemyPrefab[randomindex], transform);
            pool[i].SetActive(false); //Sets gameObjects within array as disabled by default.            
        }
    }    
}
