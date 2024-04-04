using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocator : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Transform weapon;

    void Start()
    {
        target = FindObjectOfType<EnemyMovement>().transform;        
    }

    
    void Update()
    {
        AimWeapon();
    }

    void AimWeapon()
    {
        weapon.LookAt(target);
    }
}
