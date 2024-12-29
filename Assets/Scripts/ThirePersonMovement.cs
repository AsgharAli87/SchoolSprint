using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using Vec3 = UnityEngine.Vector3;
public class ThirdPersonMovementScript : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    public float walkspeed = 5f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    public float gravity = -10f;
    public float jumpHeight = 3f;

    private Vector3 velocity;
    private bool isGrounded;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        UnityEngine.Vector3 direction = new UnityEngine.Vector3(horizontal, 0f, vertical).normalized;
        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = UnityEngine.Quaternion.Euler(0f, angle, 0f);
            UnityEngine.Vector3 moveDir = UnityEngine.Quaternion.Euler(0f, targetAngle, 0f) * UnityEngine.Vector3.forward;

            controller.Move(moveDir.normalized * walkspeed * Time.deltaTime);

        }
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        // Jump logic
        if (Input.GetButton("Jump") && isGrounded && controller.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -1f * gravity);
          
        }

        // Apply gravity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftShift) && isGrounded && controller.isGrounded)
        {

            walkspeed = 10f;

        }
        if (Input.GetKeyUp(KeyCode.LeftShift) && isGrounded && controller.isGrounded)
        {

            walkspeed = 5f;

        }
    }
}