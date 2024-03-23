using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : Archer
{
    public override void Attack()
    {
        Debug.Log("2nd job: Crossbow");
        base.Attack();
    }
}
