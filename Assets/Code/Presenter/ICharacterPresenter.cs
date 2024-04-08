using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacterPresenter
{
    string Name { get; }
    int Health { get; }
    void DealDamage();
    event Action CharacterUpdated;
}
