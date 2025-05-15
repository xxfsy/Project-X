using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerNewInputSystemHandler : MonoBehaviour, IInputHandlable
{
    // NewInputSystem ��� ������ ����� �������, ������� � ��� � ���������� ����� �������� ��� ������ ������ (������, �����), � ������� � �������� ������� ��� ��� ������ New Input System,
    // ������� �� �� �� ������ � ������ ���������� ��� ��������� ������ ������

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
