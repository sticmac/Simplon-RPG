using System.Collections;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private CharacterMovement _enemyMovement;
    [SerializeField] private Transform _enemyTransform;
    [SerializeField] private Transform _targetTransform;
    [SerializeField] private float _distanceThreshold = 0.5f;

    private const int _noMovement = 0;
    private const int _leftMovement = -1;
    private const int _rightMovement = 1;

    void Start()
    {
        StartCoroutine(EnemyMovementCoroutine());
    }

    private IEnumerator EnemyMovementCoroutine()
    {
        while (true)
        {
            // If the target is too close, we don't move
            if (Mathf.Abs(_targetTransform.position.x - _enemyTransform.position.x) < _distanceThreshold)
            {
                _enemyMovement.ModifyMovement(_noMovement);
            }
            // If the target is to the left, we move to the left
            else if (_targetTransform.position.x < _enemyTransform.position.x)
            {
                _enemyMovement.ModifyMovement(_leftMovement);
            }
            else
            {
                _enemyMovement.ModifyMovement(_rightMovement);
            }
            yield return null; // Go to next frame
        }
    }
}