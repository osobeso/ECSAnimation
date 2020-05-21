// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace ECSAnimation.Inputs
{
    public class @PlayerInput : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""87152ab3-63f5-483f-8be0-f870def50a44"",
            ""actions"": [
                {
                    ""name"": ""MOVE"",
                    ""type"": ""Value"",
                    ""id"": ""0764b62f-74d7-4ba4-974e-9cc3f8b9edc2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RUN"",
                    ""type"": ""Button"",
                    ""id"": ""a05e0c62-4935-486c-8df4-2c9b593bdd36"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CROUCH"",
                    ""type"": ""Button"",
                    ""id"": ""b56e69ea-1d89-4556-8895-1ef88c614c40"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""INTERACT"",
                    ""type"": ""Button"",
                    ""id"": ""aa753bfe-8d2a-457a-91ed-b81627d0b039"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LOOK"",
                    ""type"": ""Value"",
                    ""id"": ""4e32d7bd-8e0f-45cd-84cc-aedf414f2aae"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JUMP"",
                    ""type"": ""Button"",
                    ""id"": ""e085267c-2a19-4187-90cc-9371dd4e8d2f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""2a17c881-7423-474d-9836-889ded9ab7bf"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c8537203-9fa7-40f9-92eb-0867b71705bf"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""91bb61ed-3f70-4623-988c-3b4cc26ca6fb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6c254915-e8d3-4f29-9560-f332c75eb116"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""193ba80f-fc7d-4231-baf9-f015f74fa618"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b8d3b441-32f8-4bf4-9b52-050b5791ff2a"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""RUN"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ccbcae8-60c1-4c46-9562-b016065f77b7"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""CROUCH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de64d085-3bd7-4e01-bde9-0896efd8db28"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""INTERACT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6906a59e-dc2f-42a7-a5a7-e422a6363ab6"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""LOOK"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7bf5f989-4b5d-4498-a68e-f04322a868ba"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""JUMP"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": []
        }
    ]
}");
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_MOVE = m_Player.FindAction("MOVE", throwIfNotFound: true);
            m_Player_RUN = m_Player.FindAction("RUN", throwIfNotFound: true);
            m_Player_CROUCH = m_Player.FindAction("CROUCH", throwIfNotFound: true);
            m_Player_INTERACT = m_Player.FindAction("INTERACT", throwIfNotFound: true);
            m_Player_LOOK = m_Player.FindAction("LOOK", throwIfNotFound: true);
            m_Player_JUMP = m_Player.FindAction("JUMP", throwIfNotFound: true);
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

        // Player
        private readonly InputActionMap m_Player;
        private IPlayerActions m_PlayerActionsCallbackInterface;
        private readonly InputAction m_Player_MOVE;
        private readonly InputAction m_Player_RUN;
        private readonly InputAction m_Player_CROUCH;
        private readonly InputAction m_Player_INTERACT;
        private readonly InputAction m_Player_LOOK;
        private readonly InputAction m_Player_JUMP;
        public struct PlayerActions
        {
            private @PlayerInput m_Wrapper;
            public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @MOVE => m_Wrapper.m_Player_MOVE;
            public InputAction @RUN => m_Wrapper.m_Player_RUN;
            public InputAction @CROUCH => m_Wrapper.m_Player_CROUCH;
            public InputAction @INTERACT => m_Wrapper.m_Player_INTERACT;
            public InputAction @LOOK => m_Wrapper.m_Player_LOOK;
            public InputAction @JUMP => m_Wrapper.m_Player_JUMP;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
                {
                    @MOVE.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMOVE;
                    @MOVE.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMOVE;
                    @MOVE.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMOVE;
                    @RUN.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRUN;
                    @RUN.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRUN;
                    @RUN.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRUN;
                    @CROUCH.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCROUCH;
                    @CROUCH.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCROUCH;
                    @CROUCH.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCROUCH;
                    @INTERACT.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnINTERACT;
                    @INTERACT.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnINTERACT;
                    @INTERACT.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnINTERACT;
                    @LOOK.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLOOK;
                    @LOOK.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLOOK;
                    @LOOK.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLOOK;
                    @JUMP.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJUMP;
                    @JUMP.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJUMP;
                    @JUMP.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJUMP;
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @MOVE.started += instance.OnMOVE;
                    @MOVE.performed += instance.OnMOVE;
                    @MOVE.canceled += instance.OnMOVE;
                    @RUN.started += instance.OnRUN;
                    @RUN.performed += instance.OnRUN;
                    @RUN.canceled += instance.OnRUN;
                    @CROUCH.started += instance.OnCROUCH;
                    @CROUCH.performed += instance.OnCROUCH;
                    @CROUCH.canceled += instance.OnCROUCH;
                    @INTERACT.started += instance.OnINTERACT;
                    @INTERACT.performed += instance.OnINTERACT;
                    @INTERACT.canceled += instance.OnINTERACT;
                    @LOOK.started += instance.OnLOOK;
                    @LOOK.performed += instance.OnLOOK;
                    @LOOK.canceled += instance.OnLOOK;
                    @JUMP.started += instance.OnJUMP;
                    @JUMP.performed += instance.OnJUMP;
                    @JUMP.canceled += instance.OnJUMP;
                }
            }
        }
        public PlayerActions @Player => new PlayerActions(this);
        private int m_KeyboardMouseSchemeIndex = -1;
        public InputControlScheme KeyboardMouseScheme
        {
            get
            {
                if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
                return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
            }
        }
        public interface IPlayerActions
        {
            void OnMOVE(InputAction.CallbackContext context);
            void OnRUN(InputAction.CallbackContext context);
            void OnCROUCH(InputAction.CallbackContext context);
            void OnINTERACT(InputAction.CallbackContext context);
            void OnLOOK(InputAction.CallbackContext context);
            void OnJUMP(InputAction.CallbackContext context);
        }
    }
}
