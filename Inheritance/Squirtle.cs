using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squirtle : Pokemon
{
    void Start()
    {
        id = 007;
        name = "Squirtle";
        gender = Gender.Male;
        types = Types.Water;
        hp = 44;
        atk = 48;
        spatk = 50;
        def = 65;
        spdef = 64;
        spd = 43;
    }
}
