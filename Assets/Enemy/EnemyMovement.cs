using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<EnemyDestination> path = new List<EnemyDestination>(); //Initialize variable type List.

    void Start()
    {
        StartCoroutine(PrintWaypointName()); //How to call a coroutine similarly to calling a function.        
    }

    IEnumerator PrintWaypointName() //Return type used with foreach loops when used in coroutines.
    {
        foreach(EnemyDestination destination in path)
        {
            Debug.Log(destination.name);
            yield return new WaitForSeconds(1f); //Will leave to Start() at this line, return to this pt after 1 second, then
                                                 //continue the foreach loop and repeat until finish.

        }
    }
}
