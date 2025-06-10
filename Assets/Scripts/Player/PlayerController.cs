using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private CharacterMovement _movement;
    [SerializeField] private PlayerAttack _attack;
    [SerializeField] private CharacterJump _jump;

    public void OnMove(InputValue value)
    {
        _movement.ModifyMovement(value.Get<Vector2>().x);
    }

    public void OnAttack(InputValue value)
    {
        if (value.isPressed)
            _attack.Attack();
    }

    public void OnJump(InputValue value)
    {
        if (value.isPressed)
            _jump.Jump();
    }
}
