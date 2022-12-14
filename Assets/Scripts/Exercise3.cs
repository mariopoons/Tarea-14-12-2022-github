using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    // this variables tells the lower number and the upper number that we have put in it
    public float upper;
    public float lower;

    // when you click in the screen of the game, this will say in the console a random number
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RandomNumber(upper, lower);
        }
    }
    // This will serch a number between the lower number and the upper number
    private float RandomNumber(float low, float up)
    {
        float result;
        result = Random.Range(low, up);
        Debug.Log($"The random numbre is {result}");
        return result;
    }

}
