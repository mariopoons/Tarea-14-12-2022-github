using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    // this variables tells the total of points in the money box and the amount of euros that you add
    private float totalPoints = 9;
    public float addingPoints;

    private void Update()
    {
        // when you click in the screen of the game, this will add the money that you tell in the inspector
        if(Input.GetMouseButtonDown(0))
        {
            MoneyBox(addingPoints);
        }

    }

    // This will sum the total points with the amount of money
    private void MoneyBox(float add)
    {
        totalPoints = totalPoints + add;
        Debug.Log($"You have {totalPoints} euros.");
        
    }
}
