using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public int health;
}

public class CharactersModel : MonoBehaviour
{    
    [SerializeField] CharactersList characterList;
    public int damage;
    public List<Character> characters = new List<Character>();
    Character currentCharacter;
    int currentCharacterIndex = 0 ;

    private void Awake()
    {
        foreach (CharacterConfig character in characterList.characterList) {
            characters.Add(new Character { name = character.name, health = character.Health });
        }


    }     
}
