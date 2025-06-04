using UnityEngine;
using UnityEngine.UI;

public class LifeBarUI : MonoBehaviour
{
    [SerializeField] private PlayerLife _playerLife;

    [SerializeField] private Slider _slider;

    private void OnEnable()
    {
        _playerLife.OnHPModified += UpdateHP;
    }

    private void OnDisable()
    {
        _playerLife.OnHPModified -= UpdateHP;
    }

    private void UpdateHP(int newHP)
    {
        _slider.value = newHP;
    }
}
