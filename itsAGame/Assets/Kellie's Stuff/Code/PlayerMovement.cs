using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    public Transform player;
    public float PSpeed;

    public float playerAngle;
    
    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (characterController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        
        moveDirection.y -= gravity * Time.deltaTime;
        
        characterController.Move(moveDirection * Time.deltaTime);
        PlayerRotation();
    }

private void PlayerRotation()
{
    playerAngle += Input.GetAxis("Mouse X") * PSpeed * -Time.deltaTime;
    // playerAngle = Mathf.Clamp(playerAngle, 0, 180); 
    player.localRotation = Quaternion.AngleAxis(playerAngle,Vector3.up);
}
}