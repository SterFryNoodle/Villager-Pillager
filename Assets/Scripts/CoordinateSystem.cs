using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class CoordinateSystem : MonoBehaviour
{
    TextMeshPro labelCoords;
    Vector2Int coordinates = new Vector2Int(); //Initialize variable w/ "new" keyword as it is a  normal
                                               //struct type and NOT a monobehavior class.

    void Awake()
    {
        labelCoords = GetComponent<TextMeshPro>();
        DisplayCoordinates(); //Displays current coords text once in play mode; Doesn't update.
    }

    void Update()
    {
        if(!Application.isPlaying)
        {
            DisplayCoordinates(); //Updates & displays the coords while NOT in play mode.
        }
    }

    void DisplayCoordinates()
    {
        #if UNITY_EDITOR
        coordinates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x); //Rounds x-coord of object's parent to nearest int and stores it into x of coordinates variable.
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z); //This grabs z-coord of object's parent instead of y on the tile coord system and stores
                                                                                                               //into the y of coordinates variable.
        #endif //Solves error and tells compiler that this code is meant for editor mode only.

        labelCoords.text = coordinates.x + "," + coordinates.y;
    }
}
