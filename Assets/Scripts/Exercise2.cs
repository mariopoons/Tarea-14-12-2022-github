using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    public float centimeters;
    private float inches;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Conversion(inches, centimeters);
        }
    }

    private float Conversion(float inch, float cm)
    {
        inch = cm / 2.54f;
        Debug.Log($"The conversion is {inch} inches.");
        return inch;

    }
}
