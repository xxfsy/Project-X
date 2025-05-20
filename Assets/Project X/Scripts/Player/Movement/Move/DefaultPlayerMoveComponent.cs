using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class DefaultPlayerMoveComponent : MonoBehaviour, IPlayerMoveComposable
{
    // details of this low level class:

    [SerializeField] private float _moveSpeed = 1; 

    private CharacterController _characterController;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    //

    public void Move(Vector2 moveInput)
    {
        if (moveInput != Vector2.zero)
        {
            Debug.Log("Player is moving " + moveInput);

            moveInput *= _moveSpeed;
            _characterController.Move(moveInput * Time.deltaTime);
        }
    }
}
