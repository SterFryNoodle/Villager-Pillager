using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 2;

    int currentHitPoints;

    void Start()
    {
        currentHitPoints = maxHitPoints;
    }
    
    void OnParticleCollision(GameObject other)
    {
        DamageEnemy();
    }

    void DamageEnemy()
    {
        currentHitPoints--;

        if (currentHitPoints <= 0)
        {
            gameObject.SetActive(false); 
        }
    }
}
