using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerNewInputSystemHandler : MonoBehaviour, IInputHandlable
{
    // NewInputSystem ��� ������ ����� �������, ������� � ��� � ���������� ����� �������� ��� ������ ������ (������, �����), � ������ ������ � ������� � �������� ������� ���
    // ��� ������ New Input System, ������� �� �� �� ������ � ������ ����������, � ������� �������� ������� ������ ������� ������, � � ����� �� ������� �� ����������, � �� ��� �� ��� (?)

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
        JumpPressed = false; // ��������� �������: ����� �������������� � ������� ������ �����, ����� ������������.
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
