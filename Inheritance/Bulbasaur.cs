using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulbasaur : Pokemon
{
    void Start()
    {
        id = 001;
        name = "Bulbasaur";
        gender = Gender.Female;
        types = Types.Grass;
        hp = 45;
        atk = 49;
        spatk = 65;
        def = 49;
        spdef = 65;
        spd = 45;
    }
    
}
