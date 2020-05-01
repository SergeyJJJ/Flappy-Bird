// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/BirdBehaviour/PlayerInputSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputSystem : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputSystem"",
    ""maps"": [
        {
            ""name"": ""BirdControll"",
            ""id"": ""e6288538-6d87-4ae7-b004-ecab928116f9"",
            ""actions"": [
                {
                    ""name"": ""KeyboardJump"",
                    ""type"": ""Button"",
                    ""id"": ""daa4c5c5-7b89-423b-90ed-289945fd1d85"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0f2cd823-b923-4c9d-8640-a178ecb486e9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""KeyboardJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""967e7368-69f6-4946-a571-32d96399ab3e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""KeyboardJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Mouse"",
            ""bindingGroup"": ""Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // BirdControll
        m_BirdControll = asset.FindActionMap("BirdControll", throwIfNotFound: true);
        m_BirdControll_KeyboardJump = m_BirdControll.FindAction("KeyboardJump", throwIfNotFound: true);
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

    // BirdControll
    private readonly InputActionMap m_BirdControll;
    private IBirdControllActions m_BirdControllActionsCallbackInterface;
    private readonly InputAction m_BirdControll_KeyboardJump;
    public struct BirdControllActions
    {
        private @PlayerInputSystem m_Wrapper;
        public BirdControllActions(@PlayerInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @KeyboardJump => m_Wrapper.m_BirdControll_KeyboardJump;
        public InputActionMap Get() { return m_Wrapper.m_BirdControll; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BirdControllActions set) { return set.Get(); }
        public void SetCallbacks(IBirdControllActions instance)
        {
            if (m_Wrapper.m_BirdControllActionsCallbackInterface != null)
            {
                @KeyboardJump.started -= m_Wrapper.m_BirdControllActionsCallbackInterface.OnKeyboardJump;
                @KeyboardJump.performed -= m_Wrapper.m_BirdControllActionsCallbackInterface.OnKeyboardJump;
                @KeyboardJump.canceled -= m_Wrapper.m_BirdControllActionsCallbackInterface.OnKeyboardJump;
            }
            m_Wrapper.m_BirdControllActionsCallbackInterface = instance;
            if (instance != null)
            {
                @KeyboardJump.started += instance.OnKeyboardJump;
                @KeyboardJump.performed += instance.OnKeyboardJump;
                @KeyboardJump.canceled += instance.OnKeyboardJump;
            }
        }
    }
    public BirdControllActions @BirdControll => new BirdControllActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_MouseSchemeIndex = -1;
    public InputControlScheme MouseScheme
    {
        get
        {
            if (m_MouseSchemeIndex == -1) m_MouseSchemeIndex = asset.FindControlSchemeIndex("Mouse");
            return asset.controlSchemes[m_MouseSchemeIndex];
        }
    }
    public interface IBirdControllActions
    {
        void OnKeyboardJump(InputAction.CallbackContext context);
    }
}
