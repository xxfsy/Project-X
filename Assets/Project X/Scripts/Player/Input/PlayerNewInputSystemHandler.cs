using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerNewInputSystemHandler : MonoBehaviour, IInputHandlable
{
    // NewInputSystem это детали инпут системы, поэтому у нас в интерфейсе общие свойства для любого импута (старый, новый), а отписка и подписка событий это уже детали New Input System,
    // поэтому их мы не внесли в состав интерфейса как отдельные методы методы

    public Vector2 MoveInput => throw new System.NotImplementedException();
    public bool JumpPressed => throw new System.NotImplementedException();

    public bool SwitchViewPressed => throw new System.NotImplementedException();

    private InputSystem_Actions _gameInput;

    private void Awake()
    {
        _gameInput = new InputSystem_Actions();
    }

    private void OnEnable()
    {
        Subscribe();
    }

    private void OnDisable()
    {
        Unsibscribe();
    }

    private void Subscribe()
    {
        _gameInput.Enable();
        _gameInput.Player.Jump.performed += OnJumpPerformed;
    }

    private void Unsibscribe()
    {
        _gameInput.Disable();
        _gameInput.Player.Jump.performed -= OnJumpPerformed;
    }

    private void OnJumpPerformed(InputAction.CallbackContext obj)
    {
        JumpInputRead();
    }

    public void MoveInputRead()
    {
        throw new System.NotImplementedException();
    }

    public void JumpInputRead()
    {
        throw new System.NotImplementedException();
    }

    public void SwitchViewInputRead()
    {
        throw new System.NotImplementedException();
    }
}
