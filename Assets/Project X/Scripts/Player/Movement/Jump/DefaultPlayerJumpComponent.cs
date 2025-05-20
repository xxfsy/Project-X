using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class DefaultPlayerJumpComponent : MonoBehaviour, IPlayerJumpComposable
{
    public void Jump(bool jumpPressed)
    {
        if (jumpPressed)
        {
            Debug.Log("Player jumped");
        }
    }
}
