using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb2D;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private float _speed = 5f;

    private float _movement;

    private void Reset()
    {
        _rb2D = GetComponentInParent<Rigidbody2D>();
    }

    public void ModifyMovement(float movement)
    {
        // Flip the sprite if movement is negative (to the left)
        if (movement != 0)
        {
            _spriteRenderer.flipX = movement < 0;
        }

        _movement = movement;
    }

    private void FixedUpdate()
    {
        _rb2D.linearVelocityX = _movement * _speed * Time.fixedDeltaTime;
    }
}
