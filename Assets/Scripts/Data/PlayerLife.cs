using System;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "PlayerLife", menuName = "Scriptable Objects/PlayerLife")]
public class PlayerLife : ScriptableObject
{
    [SerializeField] private int _baseHP = 10;

    private int _HP;

    public int HP => _HP;

    public event Action<int> OnHPModified;

    public void Initialize()
    {
        _HP = _baseHP;
        OnHPModified?.Invoke(_HP);
    }

    public void TakeDamage(int damage)
    {
        _HP -= damage;
        OnHPModified?.Invoke(_HP);
        Debug.Log($"HP : {_HP}");

        if (_HP <= 0)
        {
            Debug.Log("Oups je suis mort.");
        }
    }
}
