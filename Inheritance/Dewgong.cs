using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dewgong : Pokemon
{
    void Start()
    {
        id = 087;
        name = "Dewgong";
        gender = Gender.Female;
        types = Types.Ice;
        hp = 90;
        atk = 70;
        spatk = 70;
        def = 80;
        spdef = 95;
        spd = 70;
    }
}
