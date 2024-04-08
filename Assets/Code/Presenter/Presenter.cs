using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presenter : ICharacterPresenter
{
    public string Name { get; private set; }

    public int Health { get; private set; }

    public void DealDamage()
    {
        throw new System.NotImplementedException();
    }
    public Presenter(CharacterConfig character)
    {
        Name = character.Name;
        Health = character.Health;
    }
}
