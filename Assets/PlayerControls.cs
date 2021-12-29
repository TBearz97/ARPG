//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""01294936-a789-4a7c-b215-52b2eb66155e"",
            ""actions"": [
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""610775d2-a3fa-4a44-97a4-577e9e9b8903"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""73812298-52f2-4c02-aba1-6d94347b07dd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""EquipWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""4f96ad5e-ac3d-4e36-bc2f-b5c72fad9374"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PreformAttack"",
                    ""type"": ""Button"",
                    ""id"": ""7520b8f9-981d-41f3-85bf-cc9fab9807a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""444519e4-2e5f-4df0-9023-16644c23fd52"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""0e38594e-4cea-414d-99f8-f45258207947"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""4768bbbf-9f32-4cf7-b567-c7132c1858d8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""8e0c1fa9-d04a-4bab-ac8f-59ae14136b4c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""edadcb0c-92cc-44b8-9137-7965bc6cad17"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""d1a1c89c-d8c6-44c7-8761-6d108038894d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e1d6f8bd-3e52-4747-a7f3-6985a210b021"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EquipWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""781b3e02-5ac2-4273-9674-e429f5964518"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PreformAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Interaction = m_Gameplay.FindAction("Interaction", throwIfNotFound: true);
        m_Gameplay_Movement = m_Gameplay.FindAction("Movement", throwIfNotFound: true);
        m_Gameplay_EquipWeapon = m_Gameplay.FindAction("EquipWeapon", throwIfNotFound: true);
        m_Gameplay_PreformAttack = m_Gameplay.FindAction("PreformAttack", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Interaction;
    private readonly InputAction m_Gameplay_Movement;
    private readonly InputAction m_Gameplay_EquipWeapon;
    private readonly InputAction m_Gameplay_PreformAttack;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interaction => m_Wrapper.m_Gameplay_Interaction;
        public InputAction @Movement => m_Wrapper.m_Gameplay_Movement;
        public InputAction @EquipWeapon => m_Wrapper.m_Gameplay_EquipWeapon;
        public InputAction @PreformAttack => m_Wrapper.m_Gameplay_PreformAttack;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Interaction.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteraction;
                @Interaction.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteraction;
                @Interaction.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteraction;
                @Movement.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                @EquipWeapon.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEquipWeapon;
                @EquipWeapon.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEquipWeapon;
                @EquipWeapon.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEquipWeapon;
                @PreformAttack.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPreformAttack;
                @PreformAttack.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPreformAttack;
                @PreformAttack.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPreformAttack;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interaction.started += instance.OnInteraction;
                @Interaction.performed += instance.OnInteraction;
                @Interaction.canceled += instance.OnInteraction;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @EquipWeapon.started += instance.OnEquipWeapon;
                @EquipWeapon.performed += instance.OnEquipWeapon;
                @EquipWeapon.canceled += instance.OnEquipWeapon;
                @PreformAttack.started += instance.OnPreformAttack;
                @PreformAttack.performed += instance.OnPreformAttack;
                @PreformAttack.canceled += instance.OnPreformAttack;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnInteraction(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnEquipWeapon(InputAction.CallbackContext context);
        void OnPreformAttack(InputAction.CallbackContext context);
    }
}
