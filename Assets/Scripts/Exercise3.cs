using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    private float upper;
    private float lower;


    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RandomNumber(upper, lower);
        }
    }

    private float RandomNumber(float up, float low)
    {
        float result;
        result = Random.Range(low, up);
        return result;
    }

}
