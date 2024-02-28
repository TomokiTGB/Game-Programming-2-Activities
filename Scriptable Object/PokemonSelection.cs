using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PokemonSelection : MonoBehaviour
{
    public PokemonManager pokemonManager; // so I can get the all scriptable objects (pokemon)
    public Transform parentPos; //to summon clones inside here
    public GameObject pokemonButtonPrefab; //The buttons that vill be cloned?
    public PokemonInfoView pokemonInfoView;

    void Start()
    {
        Debug.Log(pokemonManager.pokemons.Count()); //counts the pokemon in POKEMONMANAGER
        foreach (Pokemon p in pokemonManager.pokemons) //gets each pokemon in POKEMONMANAGER
        {
            GameObject buttonPrefab = Instantiate(pokemonButtonPrefab,parentPos); //create referenced 'buttonPrefab' as a GameObjet
            PokemonButton pokemonButton = buttonPrefab.GetComponent<PokemonButton>(); //get the buttons script
            pokemonButton.SetPokemonData(p); //uses code that is in pokemon button
            Button button = buttonPrefab.GetComponent<Button>();
            button.onClick.AddListener(() => pokemonInfoView.DisplayPokemon(p));
        }
        

    }
}
