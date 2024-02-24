using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PokemonButton : MonoBehaviour
{
    public TextMeshProUGUI pokemonNameTxt;
    public TextMeshProUGUI lvlText;

    public void SetPokemonData(Pokemon unit)
    {
        pokemonNameTxt.text = unit.name;
        lvlText.text = unit.level.ToString();
    }
}
