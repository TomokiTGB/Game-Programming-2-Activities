using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geodude : Pokemon
{
    void Start()
    {
        id = 074;
        name = "Geodude";
        gender = Gender.Male;
        types = Types.Rock;
        hp = 40;
        atk = 80;
        spatk = 30;
        def = 100;
        spdef = 30;
        spd = 20;
    }
}
