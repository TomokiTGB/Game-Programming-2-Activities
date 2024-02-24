using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekDaysActivity : MonoBehaviour
{
    public Enums enums;

    void Start()
    {
        switch(enums)
        {
            case Enums.Sunday: Debug.Log("Sunday"); break;
            case Enums.Monday: Debug.Log("Monday"); break;
            case Enums.Tuesday: Debug.Log("Tuesday"); break;
            case Enums.Wednesday: Debug.Log("Wednesday"); break;
            case Enums.Thursday: Debug.Log("Thursday"); break;
            case Enums.Friday: Debug.Log("Friday"); break;
            case Enums.Saturday: Debug.Log("Saturday"); break;
            default:Debug.Log("Default");break;
        }  
    }
}
