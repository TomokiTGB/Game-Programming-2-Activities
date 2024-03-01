using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charmander : Pokemon
{
    void Start()
    {
        id = 004;
        name = "Charmander";
        gender = Gender.Male;
        types = Types.Fire;
        hp = 39;
        atk = 52;
        spatk = 60;
        def = 43;
        spdef = 50;
        spd = 65;
    }
}
