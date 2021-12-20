using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Analytics;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    [SerializeField] private float jumpForce = 400f;
    //[SerializeField] private Transform groundCheck;

    const float groundedRadius = 0.2f;
    private bool grounded;
    [SerializeField] private Transform groundCheck;
    public LayerMask whatIsGround;

    public UnityEvent OnLandEvent;

    private Rigidbody2D p_Rigidbody2D;
    private bool facingRight = true;
    //public Joystick joystick;
    //private PlayerFiring playerFiring;

    public float moveSpeed = 40f;
    //public int enemyKillCount = 0;

    float horizontalMove = 0f;
    float verticalMove = 0f;
    private bool jump = false;
    private bool isLadder;
    private bool isClimbing;
    public int health = 100;

    //PlayerControls playerControls;

    public void OnWalk(InputAction.CallbackContext context)
    {
        horizontalMove = context.ReadValue<float>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        float input = context.ReadValue<float>();
        if(input > 0) { jump = true; }
        if(input <= 0) { jump = false; }
    }

    public void OnClimb(InputAction.CallbackContext context)
    {
        verticalMove = context.ReadValue<float>();
    }

    public void OnMoveStick(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        horizontalMove = input.x;
        verticalMove = input.y;
    }

    private void Awake() 
    {
        //playerControls = new PlayerControls();
        p_Rigidbody2D = GetComponent<Rigidbody2D>();

        if(OnLandEvent == null)
        {
            OnLandEvent = new UnityEvent();
        }
        //playerFiring = GetComponent<PlayerFiring>();
    }

    // Update is called once per frame
    /*void Update()
    {
        if(joystick.Horizontal >= .2f)
        {
            horizontalMove = moveSpeed;
        }
        else if(joystick.Horizontal <= -.2f)
        {
            horizontalMove = -moveSpeed;
        }
        else{horizontalMove = 0f;}

        animator.SetFloat("Speed",Mathf.Abs(horizontalMove));

        verticalMove = joystick.Vertical;

        if(verticalMove >= 0.5f && !isLadder)
        {
            jump = true;
            animator.SetBool("IsJump", true);
        }
        else if(verticalMove >= 0.5f && isLadder)
        {
            isClimbing = true;
        }

        //LevelUp();
    }*/

    private void FixedUpdate() 
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundedRadius, whatIsGround);
        if(!grounded)
        {
            OnLandEvent.Invoke();
        }

        if(isLadder && verticalMove > 0)
        {
            isClimbing = true;
            verticalMove = 1;
        }

        if(isClimbing)
        {
            p_Rigidbody2D.gravityScale = 0f;
            p_Rigidbody2D.velocity = new Vector2(p_Rigidbody2D.velocity.x, verticalMove * moveSpeed);
        }
        else
        {
            p_Rigidbody2D.gravityScale = 3.5f;
        }

        //p_Rigidbody2D.velocity = new Vector2(horizontalMove * moveSpeed, p_Rigidbody2D.velocity.y);
        MoveLeft();
        MoveRight();
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if(horizontalMove > 0 && !facingRight)
        {
            Flip();
        }
        else if(horizontalMove < 0 && facingRight)
        {
            Flip();
        }

        if(jump && grounded)
        {
            animator.SetBool("IsJump", true);
            p_Rigidbody2D.velocity = new Vector2(p_Rigidbody2D.velocity.x, 0);
            p_Rigidbody2D.AddForce(new Vector2(0f, jumpForce));
        }

        //Move(horizontalMove, jump);
        //jump = false;
    }

    /*void Move(float move, bool jump)
    {
        p_Rigidbody2D.velocity = new Vector2(move, p_Rigidbody2D.velocity.y);

        if(move > 0 && !facingRight)
        {
            Flip();
        }
        else if(move < 0 && facingRight)
        {
            Flip();
        }

        if(jump && grounded)
        {
            grounded = false;
            p_Rigidbody2D.AddForce(new Vector2(0f, jumpForce));
        }
    }*/

    /*void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            grounded = true;
            animator.SetBool("IsJump", false);
        }
    }*/

    public void OnLanding()
    {
        animator.SetBool("IsJump", false);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Ladder"))
        {
            isLadder = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.CompareTag("Ladder"))
        {
            isLadder = false;
            isClimbing = false;
        }
    }

    void Flip()
    {
        facingRight = !facingRight;

        transform.Rotate(0f, 180f, 0f);
    }

    public void takeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            AnalyticsResult DieDictionary = Analytics.CustomEvent("DieCount Dic" ,
            new Dictionary<string, object>
            {
                {"Die", 1},{"Time", Time.realtimeSinceStartup}
            });
            Debug.Log("DieDic" + DieDictionary);
            UIController uIController = FindObjectOfType<UIController>();
            uIController.EndGame();
            //gameObject.SetActive(false);
        }
    }

    public void MoveLeft()
    {
        if(horizontalMove < 0)
        {
            p_Rigidbody2D.velocity = new Vector2(horizontalMove * moveSpeed, p_Rigidbody2D.velocity.y);
        }
    }

    public void MoveRight()
    {
        if(horizontalMove > 0)
        {
            p_Rigidbody2D.velocity = new Vector2(horizontalMove * moveSpeed, p_Rigidbody2D.velocity.y);
        }
    }

    /*void LevelUp()
    {
        if(enemyKillCount == 3)
        {
            enemyKillCount = 0;
            if(playerFiring.damage < 30)
            playerFiring.damage += 5;
        }
    }*/
}
