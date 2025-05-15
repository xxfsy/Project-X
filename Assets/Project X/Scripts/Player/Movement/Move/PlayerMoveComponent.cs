using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMoveComponent : MonoBehaviour, IPlayerMoveComposable
{
    public void Move(Vector2 moveInput)
    {
        if (moveInput != Vector2.zero)
            Debug.Log("Player is moving " + moveInput);
    }
}
