using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private TMP_Text _nameText;
    [SerializeField] private Slider _healthSlider;

    private ICharacterPresenter _characterPresenter;

    public void Initialized(ICharacterPresenter characterPresenter)
    {
        _characterPresenter = characterPresenter;
        _nameText.text = characterPresenter.Name;
        _healthSlider.value = characterPresenter.Health;
        _button.onClick.RemoveAllListeners();
        _button.onClick.AddListener(GetDealDamage);
    }

    private void GetDealDamage()
    {
        _characterPresenter.DealDamage();
    }

    private void OnDisable()
    {
        _button.onClick.RemoveAllListeners();
    }
}
