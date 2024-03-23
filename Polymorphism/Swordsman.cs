using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : Adventurer
{
    public override void Attack()
    {
        Debug.Log("1st Job: Swordsman");
        base.Attack();
    }
}
