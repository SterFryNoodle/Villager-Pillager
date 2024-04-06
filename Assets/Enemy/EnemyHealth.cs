using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 2;

    int currentHitPoints;

    void OnEnable() //Resets the function everytime the gameObject attached is re-enabled.
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
