using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwtichOnOff : MonoBehaviour
{
    public ConveyorBelt conveyorBelt;
    PlayerControls playerControls;
    bool interactPressed;
    bool interactReleased;

    bool isPlayer = false;

    private void Awake() 
    {
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
                conveyorBelt.ToggleOnOff();
            }
        }

        interactPressed = false;
        interactReleased = false;
    }
}
