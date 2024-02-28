using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Pokemon", menuName ="ScriptableObjects/Pokemon")]
public class Pokemon : ScriptableObject
{
    // Common attributes for all Pokémon
    public int number;
    public string name;
    public int level;
    public Gender gender;
    public PokemonType type;
    public int hp;
    public int atk;
    public int spatk;
    public int def;
    public int spdef;
    public int speed;
    public Sprite image;
    public Moves[] moves;


    // Common behavior for all Pokémon
    public void Attack()
    {
        Debug.Log($"{name} used Tackle!");
    }

    
}



