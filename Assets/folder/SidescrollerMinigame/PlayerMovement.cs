using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Jumpstate
{
    Waiting_for_Jump,
    Jumping
}
public class PlayerMovement : MonoBehaviour
{
    private Jumpstate jumpstate;
    private Vector2 MovementInput;
    [SerializeField] private float Speed = 2;
    [SerializeField] private float JumpHeight = 5;
    private Rigidbody2D rb;
    private bool isPaused;

    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       jumpstate = Jumpstate.Waiting_for_Jump;
    }

    void Update()
    {
        MovementInput.x = Input.GetAxisRaw("Horizontal");
        MovementInput.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.W))
        {
            
            jumpstate = Jumpstate.Jumping;
        }

        if(jumpstate == Jumpstate.Jumping)
        {
            JumpHeight = MovementInput.y += JumpHeight;
            jumpstate = Jumpstate.Waiting_for_Jump;
        }
    }

    private void FixedUpdate()
    {
        MovementInput = MovementInput * Speed;
        rb.velocity = MovementInput;

    }

    public void JumpPause(bool pause)
    {
        isPaused = pause;
        if (pause)
        {
            rb.velocity = Vector2.zero;
        }
    }
}
