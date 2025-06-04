using UnityEngine;

public class DistanceWeapon : Weapon
{
    [SerializeField] private GameObject _projectile;

    public override void Attack()
    {
        Instantiate(_projectile, transform);
    }
}