using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerJumpComponent : MonoBehaviour, IPlayerJumpComposable
{
    public void Jump(bool jumpPressed)
    {
        if (jumpPressed)
            Debug.Log("Player jumped");
    }
}
