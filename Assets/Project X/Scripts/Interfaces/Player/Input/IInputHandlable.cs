using UnityEngine;

public interface IInputHandlable
{
    public Vector2 MoveInput { get; }
    public bool JumpPressed { get; }

    public bool SwitchViewPressed { get; }

    public void MoveInputRead();
    public void JumpInputRead();
    public void SwitchViewInputRead();
}
