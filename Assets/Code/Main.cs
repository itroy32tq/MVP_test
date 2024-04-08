using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] private CharactersModel _model;
    [SerializeField] private View _view;

    private void Start()
    {

        _view.Initialized(new Presenter(_model));
    }
}
