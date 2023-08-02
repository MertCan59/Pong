using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidBody;
    public float speed;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }
}
