using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private CharacterMovement _movement;

    public void OnMove(InputValue value)
    {
        _movement.ModifyMovement(value.Get<Vector2>().x);
    }
}
