using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private CharacterMovement _movement;
    [SerializeField] private PlayerAttack _attack;

    public void OnMove(InputValue value)
    {
        _movement.ModifyMovement(value.Get<Vector2>().x);
    }

    public void OnAttack(InputValue value)
    {
        if (value.isPressed)
            _attack.Attack();
    }
}
