using UnityEngine;

public class PlayerMovementController : MonoBehaviour, IPlayerMovementControllable
{
    private IPlayerJumpComposable _playerJumpComponent;
    private IPlayerMoveComposable _playerMoveComponent;

    public void HandleJump()
    {
        _playerJumpComponent.Jump();
    }

    public void HandleMove()
    {
        _playerMoveComponent.Move();
    }
}
