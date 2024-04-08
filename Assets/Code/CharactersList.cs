using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CharactersList", order = 1)]
public class CharactersList : ScriptableObject
{
    public CharacterConfig[] characterList;
}
