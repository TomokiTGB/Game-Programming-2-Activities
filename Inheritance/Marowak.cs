using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marowak : Pokemon
{
    void Start()
    {
        id = 105;
        name = "Marowak";
        gender = Gender.Female;
        types = Types.Ground;
        hp = 60;
        atk = 80;
        spatk = 50;
        def = 110;
        spdef = 80;
        spd = 45;
    }
}
