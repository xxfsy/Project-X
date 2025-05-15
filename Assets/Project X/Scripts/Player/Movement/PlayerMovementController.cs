using UnityEngine;

[RequireComponent(typeof(IPlayerMoveComposable))]
[RequireComponent(typeof(IPlayerJumpComposable))]
public class PlayerMovementController : MonoBehaviour, IPlayerMovementControllable
{
    private IPlayerMoveComposable _playerMoveComponent;
    private IPlayerJumpComposable _playerJumpComponent;

    private void Awake()
    {
        _playerMoveComponent = GetComponent<IPlayerMoveComposable>();
        _playerJumpComponent = GetComponent<IPlayerJumpComposable>();
    }

    public void HandleMove(Vector2 moveInput)
    {
        _playerMoveComponent.Move(moveInput);
    }

    public void HandleJump(bool jumpPressed)
    {
        _playerJumpComponent.Jump(jumpPressed);
    }
}
