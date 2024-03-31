using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<EnemyDestination> path = new List<EnemyDestination>(); //Initialize variable type List.
    [SerializeField][Range(0f, 5f)] float enemySpeed = 1f;

    void Start()
    {
        StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath() //Return type used with foreach loops when used in coroutines.
    {
        foreach(EnemyDestination destination in path)
        {
            Vector3 startPosition = transform.position;
            Vector3 endPosition = destination.transform.position;
            float travelPercent = 0f;

            transform.LookAt(endPosition); // rotates object based on forward movement of wherever the next destination is.
            
            while(travelPercent <= 1f)
            {
                travelPercent += Time.deltaTime * enemySpeed; // increases variable based on frame time and speed variable.
                transform.position = Vector3.Lerp(startPosition, endPosition, travelPercent); // sets current object position to a percentage to the way between start and end positions.

                yield return new WaitForEndOfFrame();
            }            
        }
    }
}
