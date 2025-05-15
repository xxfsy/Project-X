using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private IPlayerMovementControllable _playerMovementController;

    private void Update()
    {
        // ������� ��������� ����� ����� ���������� � ����������

        _playerMovementController.HandleJump();
        _playerMovementController.HandleMove();
    }
}
