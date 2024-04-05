using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int hitPoints = 2;

    int currentHitPoints;

    void Start()
    {
        currentHitPoints = hitPoints;
    }
    
    void OnParticleCollision(GameObject other)
    {
        DamageEnemy();
    }

    void DamageEnemy()
    {
        currentHitPoints--;

        if (currentHitPoints == 0)
        {
            Destroy(gameObject);
        }
    }
}
