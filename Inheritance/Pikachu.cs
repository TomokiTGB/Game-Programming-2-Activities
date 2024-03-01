using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pikachu : Pokemon
{
    void Start()
    {
        id = 025;
        name = "Pikachu";
        gender = Gender.Male;
        types = Types.Electric;
        hp = 35;
        atk = 55;
        spatk = 50;
        def = 40;
        spdef = 50;
        spd = 90;
    }
}
