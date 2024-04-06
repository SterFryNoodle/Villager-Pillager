using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] float spawnTimer = 1f;
    [SerializeField] int poolSize = 5;
    [SerializeField] GameObject enemyPrefab;

    GameObject[] pool;

    void Awake()
    {
        PopulatePool();
    }

    void Start()
    {
        
    }

   
    void PopulatePool()
    {
        pool = new GameObject[poolSize]; //Initializes pool array with size.

        for(int i = 0; i < pool.Length; i++)
        {
            pool[i] = Instantiate(enemyPrefab, transform);
            pool[i].SetActive(false); //Sets gameObjects within array as disabled by default.
        }
    }
}
