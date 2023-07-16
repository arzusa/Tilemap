using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 moveInput;
    private Rigidbody2D theRB;
    public float moveSpeed=3;

    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        moveInput.Normalize();
        theRB.velocity = new Vector2(moveInput.x * moveSpeed, moveInput.y * moveSpeed);       

    }
}
