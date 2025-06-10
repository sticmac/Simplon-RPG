using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb2D;
    [SerializeField] private float _jumpForce = 10f;

    public void Jump()
    {
        _rb2D.AddForce(_jumpForce * Vector2.up, ForceMode2D.Impulse);
    }
}