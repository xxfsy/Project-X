using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private IPlayerMovementControllable _playerMovementController;

    private void Update()
    {
        // сначала считывать инпут потом передавать в контроллер

        _playerMovementController.HandleJump();
        _playerMovementController.HandleMove();
    }
}
