// GENERATED AUTOMATICALLY FROM 'Assets/Game Folder/Scripts/Concretes/Inputs/Default Action.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace gitHubProjectNew.Inputs
{
    public class @DefaultAction : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @DefaultAction()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Default Action"",
    ""maps"": [
        {
            ""name"": ""Rocket"",
            ""id"": ""e94ca6cc-32c2-49bd-9583-c8c94d26b9a0"",
            ""actions"": [
                {
                    ""name"": ""ForceUp"",
                    ""type"": ""PassThrough"",
                    ""id"": ""891f1c7e-0489-4cd4-b7f9-bd590af1bf64"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftRight"",
                    ""type"": ""PassThrough"",
                    ""id"": ""80e39aa4-1429-432e-b116-b0b8adcb75c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b523ace5-722f-4874-8018-e37969fd9452"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForceUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""c0f765fc-20c4-4d86-8162-408e6093c648"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6991658c-9b65-419f-9038-cc2d423b5b20"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9380f2af-81bb-4e14-98cd-762f57e70bb6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Rocket
            m_Rocket = asset.FindActionMap("Rocket", throwIfNotFound: true);
            m_Rocket_ForceUp = m_Rocket.FindAction("ForceUp", throwIfNotFound: true);
            m_Rocket_LeftRight = m_Rocket.FindAction("LeftRight", throwIfNotFound: true);
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

        // Rocket
        private readonly InputActionMap m_Rocket;
        private IRocketActions m_RocketActionsCallbackInterface;
        private readonly InputAction m_Rocket_ForceUp;
        private readonly InputAction m_Rocket_LeftRight;
        public struct RocketActions
        {
            private @DefaultAction m_Wrapper;
            public RocketActions(@DefaultAction wrapper) { m_Wrapper = wrapper; }
            public InputAction @ForceUp => m_Wrapper.m_Rocket_ForceUp;
            public InputAction @LeftRight => m_Wrapper.m_Rocket_LeftRight;
            public InputActionMap Get() { return m_Wrapper.m_Rocket; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(RocketActions set) { return set.Get(); }
            public void SetCallbacks(IRocketActions instance)
            {
                if (m_Wrapper.m_RocketActionsCallbackInterface != null)
                {
                    @ForceUp.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnForceUp;
                    @ForceUp.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnForceUp;
                    @ForceUp.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnForceUp;
                    @LeftRight.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnLeftRight;
                    @LeftRight.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnLeftRight;
                    @LeftRight.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnLeftRight;
                }
                m_Wrapper.m_RocketActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @ForceUp.started += instance.OnForceUp;
                    @ForceUp.performed += instance.OnForceUp;
                    @ForceUp.canceled += instance.OnForceUp;
                    @LeftRight.started += instance.OnLeftRight;
                    @LeftRight.performed += instance.OnLeftRight;
                    @LeftRight.canceled += instance.OnLeftRight;
                }
            }
        }
        public RocketActions @Rocket => new RocketActions(this);
        public interface IRocketActions
        {
            void OnForceUp(InputAction.CallbackContext context);
            void OnLeftRight(InputAction.CallbackContext context);
        }
    }
}
