using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Presenter : ICharacterPresenter
{
    CharactersModel _model;
    int _damage;
    int currentCharacterIndex = 0;

    public string Name { get; private set; }

    public int Health { get; private set; }

    public void Init(CharactersModel model) {
        _model = model;
        _damage = model.damage;
    }

    public void DealDamage()
    {
        _model.characters[currentCharacterIndex].health -= _damage;
        if (_model.characters[currentCharacterIndex].health <= 0)
        {
            if (currentCharacterIndex < _model.characters.Count - 1)
            {
                currentCharacterIndex++;
                UpdateCharacter();
            }
            else Debug.Log("Game Over Baby");
        }

    }

    void UpdateCharacter() {
        Name = _model.characters[currentCharacterIndex].name;
        Health = _model.characters[currentCharacterIndex].health;
        CharacterUpdated?.Invoke();
    }

    public event Action CharacterUpdated;

    public Presenter(CharactersModel model)
    {
        Name = model.characters[0].name;
        Health = model.characters[0].health;
        _model = model;
        _damage = model.damage;
    }
}
