using System.Collections;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    [SerializeField] private PlayerLife _playerLife;
    [SerializeField] private string _playerTag;
    [SerializeField] private float _attackInterval = 1f;
    [SerializeField] private int _damage;

    private Coroutine _damageCoroutine;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (_damageCoroutine == null && other.CompareTag(_playerTag))
        {
            _damageCoroutine = StartCoroutine(DamageCoroutine(_damage));
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (_damageCoroutine != null && other.CompareTag(_playerTag))
        {
            StopCoroutine(_damageCoroutine);
            _damageCoroutine = null;
        }
    }

    private IEnumerator DamageCoroutine(int damage)
    {
        while (true)
        {
            _playerLife.TakeDamage(damage);
            yield return new WaitForSeconds(_attackInterval);
        }
    }
}
