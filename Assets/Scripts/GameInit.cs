using UnityEngine;

public class GameInit : MonoBehaviour
{
    [SerializeField] private PlayerLife _playerLife;

    void Awake()
    {
        _playerLife.Initialize();
    }
}
