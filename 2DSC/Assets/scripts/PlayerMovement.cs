using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public void OnMove(InputValue value)
    {
        //vector2 stores two floats x/y
        Vector2 MoveDir = value.Get<Vector2>();
        GetComponent<Rigidbody2D>().linearVelocity = MoveDir * moveSpeed;
    }
}
