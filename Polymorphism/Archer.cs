using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Adventurer
{
    public override void Attack()
    {
        Debug.Log("1st Job: Archer");
        base.Attack();
    }
}
