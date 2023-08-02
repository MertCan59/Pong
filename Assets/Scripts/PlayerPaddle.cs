using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;
    

    private void FixedUpdate()
    {
        _rigidBody.MovePosition(_rigidBody.position + _direction * Time.deltaTime*speed);
    }
    void OnMove(InputValue value)
    {
        _direction = value.Get<Vector2>();
    }
}
