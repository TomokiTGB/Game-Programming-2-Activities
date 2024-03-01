using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pidgey : Pokemon
{
    void Start()
    {
        id = 016;
        name = "Pidgey";
        gender = Gender.Female;
        types = Types.Flying;
        hp = 40;
        atk = 45;
        spatk = 35;
        def = 40;
        spdef = 35;
        spd = 56;
    }
}
