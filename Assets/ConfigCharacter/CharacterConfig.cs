using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterConfiguration", menuName = "Configurations/CharacterConfiguration")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private int _health;

    public int Health => _health;
    public string Name => _name;
}
