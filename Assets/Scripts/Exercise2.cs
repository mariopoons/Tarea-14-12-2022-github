using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    // This variables tells the centimeters and the inches
    public float centimeters;
    private float inches;

    // when you click in the screen of the game, this will divide the centimeters with the inches
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Conversion(inches, centimeters);
        }
    }

    // This will divide the centimeters with the inches that you type in the inspector
    private float Conversion(float inch, float cm)
    {
        inch = cm / 2.54f;
        Debug.Log($"The conversion is {inch} inches.");
        return inch;

    }
}
