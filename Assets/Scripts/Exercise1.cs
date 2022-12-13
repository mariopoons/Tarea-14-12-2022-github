using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    private float totalPoints = 9;
    public float addingPoints;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            MoneyBox(addingPoints);
        }

    }

    private void MoneyBox(float add)
    {
        totalPoints = totalPoints + add;
        Debug.Log($"You have {totalPoints} euros.");
        
    }
}
