using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
    // this variable is an array
    public string[] array;

    // when you click in the screen of the game, this will select a random array
    private void Update()
    
        {
            if (Input.GetMouseButtonDown(0))
            {
                RandomArray();
            }
        }

    // This will serch a random array and will display in the console which array have selected 
    private int RandomArray()
    {
        int result;
        result = Random.Range(0, array.Length);
        Debug.Log($"The random array selected is {array[result]}");
        return result;        
    }
}
