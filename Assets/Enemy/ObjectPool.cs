using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] float spawnTimer = 1f;
    [SerializeField] GameObject enemyPrefab;

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while(true)
        {
            Instantiate(enemyPrefab, transform);
            yield return new WaitForSeconds(spawnTimer);
        }
    }
}
