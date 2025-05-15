using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private IPlayerMovementControllable _playerMovementController;
    private IInputHandlable _playerNewInputSystemHandler;

    private void Awake()
    {
        // как предотвратить что тут может быть null ???
        _playerMovementController = GetComponent<IPlayerMovementControllable>();
        _playerNewInputSystemHandler = GetComponent<IInputHandlable>();
    }

    private void Update()
    {
        _playerMovementController.HandleJump(_playerNewInputSystemHandler.JumpPressed);
        _playerMovementController.HandleMove(_playerNewInputSystemHandler.MoveInput);
    }
}
