using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    public bool SwitchedOn = true;
    public bool clockwise = true;
    public float speed = 1;

    private Rigidbody2D rb;
    private Component[] animators;

    private bool isAnimated = true;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody2D>();
        animators = GetComponentsInChildren<Animator>();
    }

    private void FixedUpdate() 
    {
        if(!rb) return;

        if(SwitchedOn)
        {
            if(!isAnimated)
            {
                foreach (Animator animator in animators) animator.speed = 1;
                isAnimated = true;
            }
        }
        else
        {
            if(isAnimated)
            {
                foreach ( Animator animator in animators) animator.speed = 0;
                isAnimated = false;
            }
            return;
        }

        Vector2 position = rb.position;

        if(clockwise)
        {
            rb.position += Vector2.left * speed * Time.fixedDeltaTime;
            if(transform.localScale.x == -1) transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
        }
        else
        {
            rb.position += Vector2.right * speed * Time.fixedDeltaTime;
            if(transform.localScale.x == 1) transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
        }

        rb.MovePosition(position);
    }

    public void ToggleOnOff()
    {
        SwitchedOn = !SwitchedOn;
    }

    public void ToggleState()
    {
        clockwise = !clockwise;
    }
}
