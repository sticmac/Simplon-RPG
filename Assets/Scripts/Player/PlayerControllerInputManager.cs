using UnityEngine;

public class PlayerControllerInputManager : MonoBehaviour
{
    [SerializeField] private CharacterMovement _movement;
    [SerializeField] private PlayerAttack _attack;
    [SerializeField] private CharacterJump _jump;

    void Update()
    {
        // Mouvement
        //// 1. Version « bas niveau »
        // Si j'appuie sur la flèche de droite, je vais à droite (+1)
        // Si j'appuie sur la flèche de gauche, je vais à gauche (-1)
        // Réciproque avec WASD : D va à droite (+1) et A va à gauche (-1)
        /*bool right = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
        bool left = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        float horizontal = 0f;
        if (right)
        {
            horizontal = 1f;
        }
        else if (left)
        {
            horizontal = -1f;
        }
        _movement.ModifyMovement(horizontal);*/


        //// 2. Version plus « haut niveau »
        float horizontal = Input.GetAxis("Horizontal");
        _movement.ModifyMovement(horizontal);


        // Attaque
        //// 1. Version « bas niveau »
        //bool clicked = Input.GetMouseButtonDown(0);

        //// 2. Version plus « haut niveau »
        bool clicked = Input.GetButtonDown("Fire1");

        if (clicked)
        {
            _attack.Attack();
        }


        if (Input.GetButtonDown("Jump"))
        {
            _jump.Jump();
        }
    }
}
