using System.Collections.Generic;
using UnityEngine;

public class BareHandsWeapon : Weapon
{
    [SerializeField] private int _damage = 1;

    private List<EntityLife> _entitiesInRange = new List<EntityLife>();

    public override void Attack()
    {
        for (int i = 0 ; i < _entitiesInRange.Count ; i++)
        {
            _entitiesInRange[i].TakeDamage(_damage);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        EntityLife entityLife = other.GetComponentInChildren<EntityLife>();
        if (entityLife != null && !_entitiesInRange.Contains(entityLife))
        {
            _entitiesInRange.Add(entityLife);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        EntityLife entityLife = other.GetComponentInChildren<EntityLife>();
        if (entityLife != null && _entitiesInRange.Contains(entityLife))
        {
            _entitiesInRange.Remove(entityLife);
        }
    }
}
