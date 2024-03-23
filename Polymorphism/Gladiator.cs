using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gladiator : Swordsman
{
    public override void Attack()
    {
        Debug.Log("2nd Job: Gladiator");
        base.Attack();
    }
}
