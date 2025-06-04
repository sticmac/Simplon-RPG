using UnityEngine;

public class EntityLife : MonoBehaviour
{
    [SerializeField] private int _baseHP = 1;
    [SerializeField] private GameObject entity;

    private int _HP;

    void Start()
    {
        _HP = _baseHP;
    }

    public void TakeDamage(int damage)
    {
        _HP -= damage;

        if (_HP <= 0)
        {
            entity.SetActive(false);
        }
    }
}
