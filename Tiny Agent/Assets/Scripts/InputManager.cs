using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[DefaultExecutionOrder(-1)]
public class InputManager : Singleton<InputManager>
{
    public delegate void StartTouch(Vector2 position, float time);
    public event StartTouch OnStartTouch;
    public delegate void EndTouch(Vector2 position, float time);
    public event EndTouch OnEndTouch;

    PlayerControls playerControls;
    private Camera mainCamera;

    private void Awake() 
    {
        playerControls = new PlayerControls();
        mainCamera = Camera.main;
    }
    // Start is called before the first frame update
    void Start()
    {
        playerControls.PlayerControl.PrimaryContact.started += ctx => StartTouchPrimary(ctx);
        playerControls.PlayerControl.PrimaryContact.canceled += ctx => EndTouchPrimary(ctx);
    }

    private void OnEnable() { playerControls.Enable(); }
    private void OnDisable() { playerControls.Disable(); }

    void StartTouchPrimary(InputAction.CallbackContext context)
    {
        Debug.Log("StartTouchPrimary");
        if(OnStartTouch != null)
        {
            Vector2 input2 = playerControls.PlayerControl.PrimaryPosition.ReadValue<Vector2>();
            Vector3 input3 = ScreenToWorld(mainCamera, input2);
            OnStartTouch(input3, (float)context.startTime);
        }
    }

    void EndTouchPrimary(InputAction.CallbackContext context)
    {
        Debug.Log("EndTouchPrimary");
        if(OnEndTouch != null)
        {
            Vector2 input2 = playerControls.PlayerControl.PrimaryPosition.ReadValue<Vector2>();
            Vector3 input3 = ScreenToWorld(mainCamera, input2);
            OnEndTouch(input3, (float)context.time);
        }
    }

    private Vector3 ScreenToWorld (Camera camera, Vector3 position)
    {
        position.z = camera.nearClipPlane;
        return camera.ScreenToWorldPoint(position);
    }
    
    public Vector2 PrimaryPosition()
    {
        Vector2 input2 = playerControls.PlayerControl.PrimaryPosition.ReadValue<Vector2>();
        Vector3 input3 = ScreenToWorld(mainCamera, input2);
        return input3;
    }
}
