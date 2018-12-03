using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody2D _rigidBody;

    private void Start()
    {
        this._rigidBody = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        this._rigidBody.AddForce(new Vector2(moveHorizontal, moveVertical) * this.speed);
    }
}
