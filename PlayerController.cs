using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

public static Rigidbody2D playerBody;
public float moveSpeed = 5f;
public float maxStamina = 10f;
public float sprintSpeed;

Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        //The Player Gameobject is getting conected with the Rigidbody
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //standart movement (WASD)
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX,moveY).normalized;

        sprintSpeed = 7f;

        if (Input.GetKey(KeyCode.LeftShift))
             
         {
             moveSpeed = sprintSpeed;
         }
         else
         
         {
             sprintSpeed = moveSpeed;
         }
         if (Input.GetKeyUp(KeyCode.LeftShift))
         {
             moveSpeed = 5f;
         }

    }

    private void FixedUpdate() {
        //Bewege den Spieler
        playerBody.velocity = new Vector2(moveDirection.x *moveSpeed, moveDirection.y * moveSpeed);
    }
}


 