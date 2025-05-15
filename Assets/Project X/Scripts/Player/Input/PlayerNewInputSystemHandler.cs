using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerNewInputSystemHandler : MonoBehaviour, IInputHandlable
{
    // NewInputSystem это детали инпут системы, поэтому у нас в интерфейсе общие свойства для любого импута (старый, новый), а методы чтения и отписка и подписка событий это
    // уже детали New Input System, поэтому их мы не внесли в состав интерфейса, а сделали деталями данного класса низкого уровня, и в итоге мы зависим от абстракции, а не она от нас (?)

    public Vector2 MoveInput { get; private set; }
    public bool JumpPressed { get; private set; }

    public bool SwitchViewPressed => throw new System.NotImplementedException();

    private InputSystem_Actions _gameInput;

    private void Awake()
    {
        _gameInput = new InputSystem_Actions();
    }

    private void LateUpdate() 
    {
        JumpPressed = false; // Поведение нажатия: инпут регистрируется в течение одного кадра, затем сбрасывается.
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

        _gameInput.Player.Move.performed += OnMovePerfomed;
        _gameInput.Player.Move.canceled += OnMovePerfomed;

    }

    private void Unsibscribe()
    {
        _gameInput.Player.Jump.performed -= OnJumpPerformed;

        _gameInput.Player.Move.performed -= OnMovePerfomed;
        _gameInput.Player.Move.canceled -= OnMovePerfomed;

        _gameInput.Disable();
    }

    private void OnJumpPerformed(InputAction.CallbackContext obj)
    {
        JumpPressed = true;
    }

    private void OnMovePerfomed(InputAction.CallbackContext obj)
    {
        MoveInput = obj.ReadValue<Vector2>();
    }
}
