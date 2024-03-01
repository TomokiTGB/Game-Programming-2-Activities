using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machop : Pokemon
{
    void Start()
    {
        id = 066;
        name = "Machop";
        gender = Gender.Female;
        types = Types.Fighting;
        hp = 70;
        atk = 80;
        spatk = 35;
        def = 50;
        spdef = 35;
        spd = 35;
    }
}
