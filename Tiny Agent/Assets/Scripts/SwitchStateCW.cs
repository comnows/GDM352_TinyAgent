using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStateCW : MonoBehaviour
{
    public ConveyorBelt conveyorBelt;
    PlayerControls playerControls;
    Animator animator;
    bool interactPressed;
    bool interactReleased;

    bool isPlayer = false;
    bool isLeft = false;

    private void Awake() 
    {
        animator = GetComponent<Animator>();
        playerControls = new PlayerControls();
        playerControls.PlayerControl.Interact.performed += ctx => interactPressed = true;
        playerControls.PlayerControl.Interact.performed += ctx => interactReleased = true;
    }

    private void OnEnable() 
    {
        playerControls.Enable();
    }

    private void OnDisable() 
    {
        playerControls.Disable();
    }

    private void OnTriggerStay2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            isPlayer = true;
        }
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            isPlayer = false;
        }
    }

    private void Update() 
    {
        if(isPlayer)
        {
            if(interactPressed)
            {
                conveyorBelt.ToggleState();
                isLeft = !isLeft;
                animator.SetBool("IsLeft", isLeft);
            }
        }
            
        interactPressed = false;
        interactReleased = false;
    }
}
