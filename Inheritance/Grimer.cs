using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grimer : Pokemon
{
    void Start()
    {
        id = 088;
        name = "Grimer";
        gender = Gender.Male;
        types = Types.Poison;
        hp = 80;
        atk = 80;
        spatk = 40;
        def = 50;
        spdef = 50;
        spd = 25;
    }
}
