using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private IPlayerMovementControllable _playerMovementController; // нарушает ISP & LSP
    private IMovablePlayerMovementController _movablePlayerMovementController;
    private IJumplablePlayerMovementController _jumplablePlayerMovementController;

    private IInputHandlable _playerNewInputSystemHandler;

    private void Awake()
    {
        _movablePlayerMovementController = GetComponent<IMovablePlayerMovementController>();
        _jumplablePlayerMovementController = GetComponent<IJumplablePlayerMovementController>();

        _playerNewInputSystemHandler = GetComponent<IInputHandlable>();
    }

    private void Update()
    {
        _movablePlayerMovementController?.HandleMove(_playerNewInputSystemHandler.MoveInput);
        _jumplablePlayerMovementController?.HandleJump(_playerNewInputSystemHandler.JumpPressed);
    }
}
