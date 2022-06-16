using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerMoveSpeed = 5.0f;
    public float playerRotateSpeed = 50f;

    private CharacterController controller;
    private Vector3 playerVelocity;
    private float gravityValue = -9.81f;

    private Animator anim;//to call animator just attach to person using the script


    //jump code 
    private float jumpHeight = 5.0f;
    private bool groundedPlayer;

    // Start is called before the first frame update
    void Start()
    {
        controller = this.GetComponent<CharacterController>();

        anim = this.gameObject.GetComponent<Animator>();//gets the animator
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = transform.TransformDirection(Vector3.forward);
        //move forward
        if (Input.GetAxis("Vertical") > 0)
        {
            controller.Move(moveDir * Time.deltaTime * playerMoveSpeed);
            anim.SetInteger("Walk",1);//for walking "here put  paremeter case sensitive

            //run code
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                anim.SetBool("Run", true);
                playerMoveSpeed = 10f;//could do += to keep adding speed when running 
            }
        }

        //move backward
        else if (Input.GetAxis("Vertical") < 0)
        {
            controller.Move(-moveDir * Time.deltaTime * playerMoveSpeed);
            anim.SetInteger("Walk", 1);//if i want to add a walk backwards but would set to -1

            //run code
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                anim.SetBool("Run", true);
                playerMoveSpeed = 10f;//changes speed when run is active
            }

        }

        //not moving
        else
        {
            anim.SetInteger("Walk", 0);
            anim.SetBool("Run", false);
            playerMoveSpeed = 5f;
        }

        //rotate left
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * playerRotateSpeed);
        }
        //rotate right
        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Rotate(-Vector3.up * Time.deltaTime * playerRotateSpeed);
        }

        //jump code
        groundedPlayer = controller.isGrounded;
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            anim.SetTrigger("Jump");
            anim.SetBool("Falling", !groundedPlayer);
        }



        //gravity affects player
        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

    }
}
