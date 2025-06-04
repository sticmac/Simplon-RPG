using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private Weapon _weapon;

    public void Attack()
    {
        _weapon.Attack();
    }
}
