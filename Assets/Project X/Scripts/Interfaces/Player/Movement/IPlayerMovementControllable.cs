using UnityEngine;

public interface IPlayerMovementControllable 
{
    public void HandleMove(Vector2 moveInput); 

    public void HandleJump(bool jumpPressed); 
}
