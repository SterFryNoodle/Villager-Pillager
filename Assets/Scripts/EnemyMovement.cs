using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<EnemyDestination> path = new List<EnemyDestination>();

    void Start()
    {
        
    }

    void PrintWaypointName()
    {
        foreach(EnemyDestination destination in path)
        {
            Debug.Log(destination.name);
        }
    }
}
