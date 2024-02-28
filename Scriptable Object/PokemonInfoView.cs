using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PokemonInfoView : MonoBehaviour
{
    public Pokemon pokemon;

    [Header("UI Headers")]
    public TextMeshProUGUI numberTMP;
    public TextMeshProUGUI nameTMP;
    public TextMeshProUGUI genderTMP;
    public TextMeshProUGUI typeTMP;
    public TextMeshProUGUI hpTMP;
    public TextMeshProUGUI atkTMP;
    public TextMeshProUGUI spatkTMP;
    public TextMeshProUGUI defTMP;
    public TextMeshProUGUI spdefTMP;
    public TextMeshProUGUI speedTMP;
    public Image image;

    public void OnEnable()
    {
        //DisplayPokemon(pokemon);
    }
    public void DisplayPokemon(Pokemon pokemon)
    {
        numberTMP.text = pokemon.number.ToString();
        nameTMP.text = pokemon.name;
        genderTMP.text = pokemon.gender.ToString();
        typeTMP.text = pokemon.type.ToString();
        hpTMP.text = pokemon.hp.ToString();
        atkTMP.text = pokemon.atk.ToString();
        spatkTMP.text = pokemon.spatk.ToString();
        defTMP.text = pokemon.def.ToString();
        spdefTMP.text = pokemon.spdef.ToString();
        speedTMP.text = pokemon.speed.ToString();
        image.sprite = pokemon.image;

    }

    public void ClearView()
    {
        pokemon = null;
        nameTMP.text = null;
        genderTMP.text = null;
    }
    public void OnDisable()
    {
        ClearView();
    }
}
