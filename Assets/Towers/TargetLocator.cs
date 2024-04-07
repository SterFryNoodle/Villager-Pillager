using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocator : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Transform weapon;
            
    void Update()
    {
        FindClosestTarget();
        AimWeapon();
    }

    void FindClosestTarget()
    {
        Enemy[] enemies = FindObjectsOfType<Enemy>();
        Transform closestEnemy = null;
        float maxDistance = Mathf.Infinity; //Sets distance and assigns to max value possible.

        foreach (Enemy enemy in enemies)
        {
            float targetDistance = Vector3.Distance(transform.position, enemy.transform.position); //Assigns the distance between the position of towers and position of enemy it targets.

            if (targetDistance < maxDistance)
            {
                closestEnemy = enemy.transform;
                maxDistance = targetDistance; //adjusts max distance to difference of distance value of current enemy target.
            }
            
        }
        target = closestEnemy;
    }
    void AimWeapon()
    {
        weapon.LookAt(target);
    }
}
