using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb2D;

    [SerializeField] private float _speed = 10f;
    [SerializeField] private int _damage = 1;

    void Start()
    {
        _rb2D.linearVelocityX = _speed;
        _rb2D.gravityScale = 0f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        EntityLife entityLife = collision.collider.GetComponentInChildren<EntityLife>();
        if (entityLife != null)
        {
            entityLife.TakeDamage(_damage);
        }

        Destroy(gameObject);
    }
}