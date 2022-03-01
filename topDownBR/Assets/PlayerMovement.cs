using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 5;
    public Rigidbody2D rb;
    
    Vector2 movement;
    Vector2 startPosition;
    Vector2 mousePos;
    
    public Camera cam;
    void Start() {
        startPosition.x = 0;
        startPosition.y = 0;
        rb.MovePosition(startPosition);
    }
    
    void Update() {
        // moving
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        // aiming
        // mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        
    }
    
    void FixedUpdate() {
        // moving
        //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        
        //aiming
        // Vector2 lookDirection = mousePos - rb.position;
        // float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg + 90f;
        // rb.rotation = angle;
    }
    
}
