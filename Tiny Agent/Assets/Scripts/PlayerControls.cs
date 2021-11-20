// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerControl"",
            ""id"": ""c3fc2b22-1e2b-4ab4-9909-bde1ddaa660c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""a2bdfb7b-6b8f-4c57-8701-f14eb16e0fc8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""2fd10237-0062-41d7-aad8-44808179167a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""089e4a62-8957-4e6d-9e8d-5de233d0cd79"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Climb"",
                    ""type"": ""Button"",
                    ""id"": ""0715feae-36c0-4f74-b38b-4ce1ab0aa2df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveStick"",
                    ""type"": ""Value"",
                    ""id"": ""d9ed4679-283d-4376-bbdc-c22cc36ab420"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JumpStick"",
                    ""type"": ""Button"",
                    ""id"": ""f6ae85e0-1560-4f9c-bcbc-19256dbfc013"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""16ece59e-91c0-428b-96c6-2cc2288ae40b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary Contact"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e8478b48-1b7e-4ddc-abba-2643cb3eb9d9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Primary Position"",
                    ""type"": ""PassThrough"",
                    ""id"": ""79fe28b8-38f3-4694-9fad-2c0510a18615"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""839c6e03-5fdf-4483-ab49-d83896d75844"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""67cadd4e-a823-4352-88b9-77edccf1fae1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d3817ae0-b077-47e5-b6dd-42a657e3ab15"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""26b7d75d-502b-4bac-835b-4f3d4e32b871"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""079005b4-d7e5-4882-8a3c-b05530631ec9"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca900b1c-ddc9-4669-8be0-60e088ab7d7a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Climb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2303c5f3-ccfb-414a-aa11-0d93798cee93"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0bdf100e-1e9e-4617-a4b2-0f18866c4da8"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd45b5e6-2712-4ff9-8bc7-82ad39eaa343"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80c0ab59-4227-4950-abae-37e448da9928"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b77ec0b2-d46c-4287-b8db-19108c53e461"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Contact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""709c2a64-c132-4c97-bed1-2a296e3b98f7"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControl
        m_PlayerControl = asset.FindActionMap("PlayerControl", throwIfNotFound: true);
        m_PlayerControl_Move = m_PlayerControl.FindAction("Move", throwIfNotFound: true);
        m_PlayerControl_Jump = m_PlayerControl.FindAction("Jump", throwIfNotFound: true);
        m_PlayerControl_Shoot = m_PlayerControl.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerControl_Climb = m_PlayerControl.FindAction("Climb", throwIfNotFound: true);
        m_PlayerControl_MoveStick = m_PlayerControl.FindAction("MoveStick", throwIfNotFound: true);
        m_PlayerControl_JumpStick = m_PlayerControl.FindAction("JumpStick", throwIfNotFound: true);
        m_PlayerControl_Interact = m_PlayerControl.FindAction("Interact", throwIfNotFound: true);
        m_PlayerControl_PrimaryContact = m_PlayerControl.FindAction("Primary Contact", throwIfNotFound: true);
        m_PlayerControl_PrimaryPosition = m_PlayerControl.FindAction("Primary Position", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // PlayerControl
    private readonly InputActionMap m_PlayerControl;
    private IPlayerControlActions m_PlayerControlActionsCallbackInterface;
    private readonly InputAction m_PlayerControl_Move;
    private readonly InputAction m_PlayerControl_Jump;
    private readonly InputAction m_PlayerControl_Shoot;
    private readonly InputAction m_PlayerControl_Climb;
    private readonly InputAction m_PlayerControl_MoveStick;
    private readonly InputAction m_PlayerControl_JumpStick;
    private readonly InputAction m_PlayerControl_Interact;
    private readonly InputAction m_PlayerControl_PrimaryContact;
    private readonly InputAction m_PlayerControl_PrimaryPosition;
    public struct PlayerControlActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerControlActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerControl_Move;
        public InputAction @Jump => m_Wrapper.m_PlayerControl_Jump;
        public InputAction @Shoot => m_Wrapper.m_PlayerControl_Shoot;
        public InputAction @Climb => m_Wrapper.m_PlayerControl_Climb;
        public InputAction @MoveStick => m_Wrapper.m_PlayerControl_MoveStick;
        public InputAction @JumpStick => m_Wrapper.m_PlayerControl_JumpStick;
        public InputAction @Interact => m_Wrapper.m_PlayerControl_Interact;
        public InputAction @PrimaryContact => m_Wrapper.m_PlayerControl_PrimaryContact;
        public InputAction @PrimaryPosition => m_Wrapper.m_PlayerControl_PrimaryPosition;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlActions instance)
        {
            if (m_Wrapper.m_PlayerControlActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnJump;
                @Shoot.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnShoot;
                @Climb.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnClimb;
                @Climb.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnClimb;
                @Climb.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnClimb;
                @MoveStick.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMoveStick;
                @MoveStick.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMoveStick;
                @MoveStick.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMoveStick;
                @JumpStick.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnJumpStick;
                @JumpStick.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnJumpStick;
                @JumpStick.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnJumpStick;
                @Interact.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnInteract;
                @PrimaryContact.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnPrimaryContact;
                @PrimaryContact.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnPrimaryContact;
                @PrimaryContact.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnPrimaryContact;
                @PrimaryPosition.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnPrimaryPosition;
                @PrimaryPosition.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnPrimaryPosition;
                @PrimaryPosition.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnPrimaryPosition;
            }
            m_Wrapper.m_PlayerControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Climb.started += instance.OnClimb;
                @Climb.performed += instance.OnClimb;
                @Climb.canceled += instance.OnClimb;
                @MoveStick.started += instance.OnMoveStick;
                @MoveStick.performed += instance.OnMoveStick;
                @MoveStick.canceled += instance.OnMoveStick;
                @JumpStick.started += instance.OnJumpStick;
                @JumpStick.performed += instance.OnJumpStick;
                @JumpStick.canceled += instance.OnJumpStick;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @PrimaryContact.started += instance.OnPrimaryContact;
                @PrimaryContact.performed += instance.OnPrimaryContact;
                @PrimaryContact.canceled += instance.OnPrimaryContact;
                @PrimaryPosition.started += instance.OnPrimaryPosition;
                @PrimaryPosition.performed += instance.OnPrimaryPosition;
                @PrimaryPosition.canceled += instance.OnPrimaryPosition;
            }
        }
    }
    public PlayerControlActions @PlayerControl => new PlayerControlActions(this);
    public interface IPlayerControlActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnClimb(InputAction.CallbackContext context);
        void OnMoveStick(InputAction.CallbackContext context);
        void OnJumpStick(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnPrimaryContact(InputAction.CallbackContext context);
        void OnPrimaryPosition(InputAction.CallbackContext context);
    }
}
